package edu.wctc.james.model;

public class Product {
    private int productID;
    private String name;
    private double price;
    private boolean featured;
    private String description;
    private String image;

    public Product(int productID, String name, double price, boolean featured, String description, String image) {
        this.productID = productID;
        this.name = name;
        this.price = price;
        this.featured = featured;
        this.description = description;
        this.image = image;
    }

    public int getProductID() {
        return productID;
    }

    public String getName() {
        return name;
    }

    public double getPrice() {
        return price;
    }

    public boolean isFeatured() {
        return featured;
    }

    public String getDescription() {
        return description;
    }

    public String getImage() {
        return image;
    }
}
