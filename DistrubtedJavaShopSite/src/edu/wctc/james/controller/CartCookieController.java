package edu.wctc.james.controller;

import edu.wctc.james.model.CartItem;
import edu.wctc.james.model.Product;
import edu.wctc.james.model.ProductCatalog;

import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Enumeration;
import java.util.List;

public class CartCookieController extends HttpServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        Enumeration paramNames = request.getParameterNames();
        String paramName;
        String quantity;
        String itemQuantity;
        String theOrder = "Empty Cart";

        while(paramNames.hasMoreElements())
        {
            paramName = (String) paramNames.nextElement();
            if (paramName.equals("cartItem"))
            {
                String[] paramValues = request.getParameterValues(paramName);
                    theOrder = "";
                    for (int i = 0; i < paramValues.length; i++)
                    {
                        if (request.getParameter("removeItem" + paramValues[i]) == null)
                        {
                            theOrder += paramValues[i] + "=";
                            quantity = "quantityOf" + paramValues[i];
                            itemQuantity = request.getParameter(quantity);
                            if (itemQuantity.isEmpty()) {
                                theOrder += "1,";
                            } else {
                                theOrder += request.getParameter(quantity) + ",";
                            }
                        }
                    }
                    theOrder = theOrder.substring(0, theOrder.length() - 1);
            }
        }
            Cookie items = new Cookie("cartItem", theOrder);
            // Set expiry date after 24 Hrs for both the cookies.
            items.setMaxAge(60*60*24);
            response.addCookie( items );

            String site;
            if (request.getParameter("completePurchase") != null)
            {
                site = request.getParameter("location2");
                Cookie order = new Cookie("orderCompleted", theOrder);
                // Set expiry date after 24 Hrs for both the cookies.
                items.setMaxAge(60*60*24);
                response.addCookie( order );
            }
            else if(request.getParameter("continuePurchase") != null)
            {
                site = request.getParameter("location2");
            }
            else
            {
                site = request.getParameter("location");
            }
            response.setStatus(response.SC_MOVED_TEMPORARILY);
            response.setHeader("Location", site);
    }

    protected List<CartItem> orderedItems(String itemsNumbers) {
        List<CartItem> cartItemList = new ArrayList();
        ProductCatalog cat = new ProductCatalog();
        String[] nums = itemsNumbers.split(",");
        for (int i=0;i<nums.length;i++) {
            String[] cartItems = nums[i].split("=");
            Product product = cat.getSingleItem(Integer.parseInt(cartItems[0]));
            int quantity = Integer.parseInt(cartItems[1]);
            cartItemList.add( new CartItem(product, quantity));
        }
        return cartItemList;
    }
}

