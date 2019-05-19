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

    <title>Shop - Home</title>

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

<!-- Header -->
<header class="bg-primary py-5 mb-5">
    <div class="container h-100">
        <div class="row h-100 align-items-center">
            <div class="col-lg-12">
                <h1 class="display-4 text-white mt-5 mb-2">WELCOME, to My Shop Site!</h1>
                <p class="lead mb-5 text-white-50">The Site Where WE sell YOU stuff that we have way too much of!</p>
            </div>
        </div>
    </div>
</header>

<!-- Page Content -->
<div class="container">

    <div class="row">
        <div class="col-md-8 mb-5">
            <h2>What We Do</h2>
            <hr>
            <p>We try to sell ya stuff!</p>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. A deserunt neque tempore recusandae animi soluta quasi? Asperiores rem dolore eaque vel, porro, soluta unde debitis aliquam laboriosam. Repellat explicabo, maiores!</p>
            <p>We mainly just hope you buy something...</p>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis optio neque consectetur consequatur magni in nisi, natus beatae quidem quam odit commodi ducimus totam eum, alias, adipisci nesciunt voluptate. Voluptatum.</p>
            <a class="btn btn-primary btn-lg" href="catalog.go">Check Out Our Stuff! &raquo;</a>
        </div>
        <div class="col-md-4 mb-5">
            <h2>Contact Us</h2>
            <hr>
            <address>
                <strong>My Shop Site</strong>
                <br>12345 Buy Stuff Lane
                <br>Point Place, WI 53111
                <br>
            </address>
            <address>
                <abbr title="Phone">P:</abbr>
                (123) 456-7890
                <br>
                <abbr title="Email">E:</abbr>
                <a href="mailto:#">pleasebuysomething@myshopsite.com</a>
            </address>
        </div>
    </div>
    <!-- /.row -->
    <!-- Editable table -->
    <div class="card">
        <h3 class="card-header text-center font-weight-bold text-uppercase py-4">Featured Products</h3>
        <div class="card-body">
            <div id="table" class="table-editable">
                        <span class="table-add float-right mb-3 mr-2">
                            <a href="#!" class="text-success">
                                <i class="fas fa-plus fa-2x" aria-hidden="true"></i>
                            </a>
                        </span>
    <form action="CookieCart.go" class="form-inline">
        <input type="hidden" name="location" value="index.jsp">
        <div class="row">
            <%
                List recs = (List) request.getAttribute("catalog");
                Iterator it = recs.iterator();
                while (it.hasNext()) {
                    Product product = (Product) it.next();
                    out.print("<div class='col-md-4 mb-5'>");
                    out.print("<div class='card h-100' style='max-width:450px'>");
                    out.print("<img class='card-img-top' src='" + product.getImage() + "' alt='' style='max-height:450px;'>");
                    out.print("<div class='card-body'>");
                    out.print("<h4 class='card-title'>" + product.getName() + "</h4>");
                    out.print("<p class='card-text'>" + product.getDescription() + " " + product.getPrice() + "</p>");
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
            <input type="submit" value="Purchase" class="btn btn-success btn-lg" style="width: 30%;">
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
<script src="vendor/jquery/jquery.min.js"></script>
<script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

</body>

</html>
