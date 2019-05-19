package edu.wctc.james.model;

import java.util.ArrayList;
import java.util.List;

public class ProductCatalog {
    private List<Product> productCatalog = new ArrayList<>();
    private int nextProductNumber;

    public ProductCatalog() {
        nextProductNumber = 1;
        productCatalog.add(new Product(nextProductNumber++,"1800 REPOSADO TEQUILA",25.99,false,"Size: 750ML,  Mexico – This moderately full-bodied gold tequila is smooth with butterscotch, vanilla and toasted coconut flavors. The oak barrel aging process allows for a sweet then dry well rounded finish.","images/1800-rep-500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"PATRON SILVER",38.99,true,"Size: 750ML, Mexico - 100% Blue Agave. Crystal clear, pure ultra premium. Light, fresh tequila is a favorite of connoisseurs worldwide. Smooth, soft, light tequila. The perfect ingredient in special margaritas or mixed cocktails, neat or on the rocks.","images/PatronSilver__500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"PAUL MASSON BRANDY GRANDE AMBER", 12.99,true,"California - Amber in color, filled with vanilla, pear, and soft chocolate aromas. Flavors of caramel, vanilla, and dried fruit are noted in the smooth, well-aged, and complex finish.","images/paul-masson-500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"EVAN WILLIAMS",24.99,false,"Wine Enthusiast - Kentucky, USA - All the corn and oak you'd want, with mint edging around the sides to lift it, but it doesn't blow your head up with your Bourbon head and roughness. Heaven Hill gives it a few extra years int he barrel, and it pays off in smoother character. Enjoy neat or on the rocks.","images/even-williams-500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"TANQUERAY GIN",18.99,false,"United Kingdom- Crafted using a time honored recipe of only the highest quality grains, the purest water, the most select juniper berries, finest botanicals, and a unique quadruple-distillation process.","images/tanqueray_500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"BOMBAY SAPPHIRE",21.99,true,"England-The spirit is triple distilled, and the alcohol vapors are passed through bundles of the herbs and spices in order to gain flavor and aroma of almond, lemon peel, liquorice, juniper berries, orris root, angelica, coriander, cassia, cubeb, and grains of paradise.","images/bombay-saph-500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"KETEL ONE",16.99,false,"Wine Enthusiast -Netherlands- Clear as rainwater. Bouquet doesn't reach up and grab you as much as it seduces you with gentle waves of mild spirit and grainy richness. The palate entry offers mild spiciness and cereal sweetness...Classy and complex. Distilled 3 times in a copper potstill. Best neat.","images/ketelone-500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"GREY GOOSE",24.99,false,"France- World's best tasting vodka. Single origin soft winter wheat from picardi and natural spring water from Gensac la Pallue. Every step of our process is designed to express the extraordinary character of our wheat. Naturally rich and full bodied taste with a smooth mouthfeel.","images/greygoose-500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"JAMESON IRISH WHISKEY",22.99,false,"Wine Enthusiast -Ireland- A pot still whiskey blended of light and medium flavored whiskies that were triple distilled for exceptional smoothness. Matured in Bourbon and Sherry casks to produce a crisp, clean, mellow taste with sweet, spicy, vanilla tones, and a subtle finish. Very smooth and versatile.","images/jameson-500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"STELLA ARTOIS",7.99,false,"Belgium- Euro Pale Lager- Traditional malted barley and the finest European hops give Stella Artois its superior quality and full characteristic flavor. The history of Stella Artois can be traced back to 1366 in Leuven, Belgium.","images/stella-500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"ANGRY ORCHARD CRISP APPLE CIDER",6.99,false,"Massachusetts- Fruit Cider- This crisp and refreshing cider mixes the sweetness of the apples with a subtle dryness for a balanced cider taste. The fresh apple aroma and slightly sweet, ripe apple flavor make this cider hard to resist.","images/angry-orchard-500x500.jpg"));
        productCatalog.add(new Product(nextProductNumber++,"DANSK MJOD VIKING BLOD MEAD",25.99,false,"Denmark- This artisan metheglin-style Danish mead has hibiscus and hops, which give it a soft, citrus-like flavor and very floral aroma. Its finish is hoppy-dry, spicy, and very warming.","images/dansk mjod viking blod-500x500.gif"));
    }

    public List<Product> getProductCatalog() {
        return productCatalog;
    }

    public List<Product> getFeaturedItemCatalog() {
        List<Product> product = new ArrayList<>();

        for(Product i: productCatalog) {
            if (i.isFeatured()) {
                product.add(i);
            }
        }
        return product;
    }
    public Product getSingleItem(int itemNum) {
        Product product =null;

        for(Product i: productCatalog) {
            if (i.getProductID() == itemNum) {
                return i;
            }
        }
        return product;
    }

    public List<Product> getFilteredList(String s){
        List<Product> product = new ArrayList<>();

        for (Product i: productCatalog)
        {
            if (i.getName().toLowerCase().contains(s.toLowerCase()))
            {
                product.add(i);
            }

        }
        return product;
    }
}
