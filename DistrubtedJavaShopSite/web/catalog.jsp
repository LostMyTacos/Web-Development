<%@ page import="java.util.List" %>
<%@ page import="java.util.Iterator" %>
<%@ page import="edu.wctc.james.model.Product" %>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Shop - Catalog</title>

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
                <li class="nav-item">
                    <a class="nav-link" href="index.jsp">Home</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="catalog.go">Products<span class="sr-only">(current)</span></a>
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
    <%
        List recs = (List) request.getAttribute("catalog");
        int catalogSize = (Integer)request.getAttribute("catalogSize");
        int totalItems = recs.size();
    %>

    <div class="card">
        <h3 class="card-header text-center font-weight-bold text-uppercase py-4">Our Products</h3>
        <h4 class="card-header text-center">Displaying: <% out.print(totalItems + " out of " + catalogSize); %> Items</h4>
        <div class="card-body">
            <div id="table" class="table-editable">
                        <span class="table-add float-right mb-3 mr-2">
                            <a href="#!" class="text-success">
                                <i class="fas fa-plus fa-2x" aria-hidden="true"></i>
                            </a>
                        </span>
            <form action="CookieCart.go" class="form-inline">
                <input type="hidden" name="location" value="catalog.go">
                <div class="row">
                <%
                    Iterator it = recs.iterator();
                    while (it.hasNext()) {
                        Product product = (Product) it.next();
                        out.print("<div class='col-lg-4 col-md-4 mb-5'>");
                        out.print("<div class='card h-100' style='max-width:450px'>");
                        out.print("<img class='card-img-top' src='" + product.getImage() + "' alt='' style='max-height:450px;'>");
                        out.print("<div class='card-body'>");
                        out.print("<h4 class='card-title'>" + product.getName() + "</h4>");
                        out.print("<h5>" + product.getPrice() + "</h5>");
                        out.print("<p class='card-text'>" + product.getDescription() + "</p>");
                        out.print("</div>");
                        out.print("<label class='sr-only' for='inlineFormInputGroup'>Quantity</label>");
                        out.print("<div class='input-group'>");
                        out.print("<input type='number' class='form-control' name='quantityOf" + product.getProductID() + "' placeholder='Quantity' style='text-align:center;' min='1' max='5'>");
                        out.print("</div>");
                        out.print("<div class='form-check'>");
                        out.print("<label class='form-check-label'>");
                        out.print("<input type='checkbox' class='form-check-input' name='cartItem' value=" + product.getProductID() + ">Add To Cart</label>");
                        out.print("</div>");
                        out.print("</div>");
                        out.print("</div>");
                    }
                %>

                </div>
            <div class="col-md-8 mb-5">
                <input type="submit" value="Purchase" class="btn btn-success btn-lg">
            </div>

            </form>

            </div>
            <!-- /.col-lg-9 -->
        </div>
        <!-- /.row -->
    </div>
</div>
    <!-- /.container -->
    <!-- Footer -->
    <footer class="py-5 bg-dark">
        <div class="container">
            <p class="m-0 text-center text-white">Copyright &copy; My Shop Site - 2019</p>
        </div>
    </footer>

<!-- Bootstrap core JavaScript -->
<script src="../vendor/jquery/jquery.min.js"></script>
<script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

</body>

</html>
