<%@ page import="java.util.List" %>
<%@ page import="java.util.Iterator" %>
<%@ page import="edu.wctc.james.model.Product" %>
<%@ page import="edu.wctc.james.model.CartItem" %>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Shop - Bill</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="css/main.css" rel="stylesheet">

</head>

<body>

<!-- Navigation -->
<nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
    <div class="container">
        <a class="navbar-brand" href="index.jsp">My Shop Site</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarResponsive">
            <ul class="navbar-nav ml-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="index.jsp">Home
                        <span class="sr-only">(current)</span>
                    </a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="catalog.go">Products</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="cart.go">My Cart</a>
                </li>
                <li class="nav-item">
                    <form class="form-inline" action="catalog.go">
                        <input class="form-control mr-sm-2" name="searchInput" type="text" placeholder="Search">
                        <button class="btn btn-success" type="submit">Search</button>
                    </form>
                </li>
            </ul>
        </div>
    </div>
</nav>

<!-- Page Content -->
<div class="container">

    <!-- Editable table -->
    <div class="card">
        <h3 class="card-header text-center font-weight-bold text-uppercase py-4">Your Bill</h3>
        <div class="card-body">
            <div id="table" class="table-editable">
                <form action="CookieCart.go">
                    <input type="hidden" name="location" value="cart.go">
                    <input type="hidden" name="location2" value="bill.go">
                    <table class="table table-bordered table-responsive-md table-striped text-center">
                        <tr>
                            <th class="text-center">Product</th>
                            <th class="text-center">Price</th>
                            <th class="text-center">Quantity</th>
                            <th class="text-center">Total</th>
                        </tr>
                        <%
                            List recs = (List) request.getAttribute("catalog");
                            Iterator it = recs.iterator();
                            double total = 0;
                            while (it.hasNext()) {
                                CartItem cartItem = (CartItem) it.next();
                                Product product = cartItem.getProduct();
                                out.print("<tr>" +
                                        "<td class='pt-3-half'>" + product.getName() + "</td>" +
                                        "<td class='pt-3-half'>" + String.format("$%3.2f", product.getPrice()) + "</td>" +
                                        "<td class='pt-3-half'>" + cartItem.getQuantity() + "</td>" +
                                        "<input type='hidden' class='form-control' name='quantityOf" + product.getProductID() + "' value=" + cartItem.getQuantity() + " style='text-align:center;' min='1' max='5'>" +
                                        "<td class='pt-3-half'>" + String.format("$%3.2f", cartItem.getTotal()) + "</td>" +
                                        "</tr>");
                                out.print("<input type='hidden' class='form-check-input' name='cartItem' value=" + product.getProductID() + ">");
                                total += product.getPrice();
                            }
                            double tax = total * 0.0765;
                            double grandTotal = total + tax;

                            out.print("<tr>" +
                                    "<td class='pt-3-half'></td>" +
                                    "<td class='pt-3-half'></td>" +
                                    "<td class='pt-3-half' style='font-weight: bolder'>Sub-Total</td>" +
                                    "<td class='pt-3-half'>" + String.format("$%3.2f", total) + "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                    "<td class='pt-3-half'></td>" +
                                    "<td class='pt-3-half'></td>" +
                                    "<td class='pt-3-half' style='font-weight: bolder'>Tax</td>" +
                                    "<td class='pt-3-half'>"+ String.format("$%3.2f", tax) + "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                    "<td class='pt-3-half'></td>" +
                                    "<td class='pt-3-half'></td>" +
                                    "<td class='pt-3-half' style='font-weight: bolder'>Grand-Total</td>" +
                                    "<td class='pt-3-half'>"+ String.format("$%3.2f", grandTotal) + "</td>" +
                                    "</tr>");
                        %>
                    </table>
                    <!-- Editable table -->
                    <div class="col-md-8 mb-5">
                        <input type="submit" class="btn btn-danger btn-lg" name="backToCart" value="Return to Cart">
                        <input type="submit" class="btn btn-success btn-lg" name="completePurchase" value="Complete Purchase">
                    </div>
                </form>
            </div>

        </div>
    </div>
</div>
<!-- /.container -->

<!-- Footer -->
<footer class="py-5 bg-dark">
    <div class="container">
        <p class="m-0 text-center text-white">Copyright &copy; My Shop Site - 2019</p>
    </div>
    <!-- /.container -->
</footer>

<!-- Bootstrap core JavaScript -->
<script src="../vendor/jquery/jquery.min.js"></script>
<script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

</body>

</html>

