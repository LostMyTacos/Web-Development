package edu.wctc.james.controller;

import edu.wctc.james.model.*;
import edu.wctc.james.model.Product;
import edu.wctc.james.model.ProductCatalog;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;

@WebServlet(name = "CartServlet")
public class CartController extends HttpServlet {
    private String RESULT_PAGE = "cart.jsp";

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        Cookie cookie = null;
        Cookie[] cookies = null;
        // Get an array of Cookies associated with the this domain
        cookies = request.getCookies();
        PrintWriter out = response.getWriter();
        List<CartItem> cart = new ArrayList<>();
        if( cookies != null )
        {
            for (int i = 0; i < cookies.length; i++)
            {
                cookie = cookies[i];
                if (cookie.getName().equals("cartItem"))
                {
                    if(cookie.getValue().equals("Empty Cart"))
                    {
                        cart = null;
                        request.setAttribute("catalog", cart);
                    }
                    else
                    {
                        cart = orderedItems(cookie.getValue());
                    }

                }
            }
        }
        request.setAttribute("catalog", cart);

        RequestDispatcher view =
            request.getRequestDispatcher(RESULT_PAGE);
        view.forward(request, response);
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

