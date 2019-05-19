// JavaScript Document
var app = angular.module('mainApp', ['ui.bootstrap', 'ngRoute', 'firebase']);

// You will need to supply your own IGDB API Key From:https://www.igdb.com/api
app.userKey = '{Insert Your API Key Here}';


// define some global variables available to the entire app
app.run(function($rootScope, $location, $routeParams) {
	
	var d = new Date();
    $rootScope.appName = 'Gaming Site';
	$rootScope.copyright = d.getFullYear();
	
	$rootScope.isActive = function(viewPath){
		return viewPath == $location.path();
	};
	
	$rootScope.latestProducts = [
						{
						image: 'images/RDR2Art.png', 
						image2: 'images/RedDead2.jpg', 
						name: 'Red Dead Redemption 2', 
						text: 'Developed by the creators of Grand Theft Auto V and Red Dead Redemption, Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game\'s vast and atmospheric world will also provide the foundation for a brand new online multiplayer experience.', 
						id: 0, 
						productId: 25076
						},
						{
						image: 'images/ACOdysseyArt.jpg', 
						image2: 'images/Odyssey.jpg', 
						name: 'Assassins Creed: Odyssey', 
						text: 'Write your own epic odyssey and become a legendary Spartan hero in Assassin\'s Creed Odyssey, an inspiring adventure where you must forge your destiny and define your own path in a world on the brink of tearing itself apart. Influence how history unfolds as you experience a rich and ever-changing world shaped by your decisions.',
						id: 1, 
						productId: 103054
						},
						{
						image: 'images/D2ForsakenArt.jpg', 
						image2: 'images/Forsaken.jpeg', 
						name: 'Destiny 2: Forsaken', 
						text: 'Take justice into your own hands as you venture into a new frontier filled with enemies, allies, untold mysteries, and treasures waiting to be uncovered.', 
						id: 2, 
						productId: 103204}
					];
	
	app.initFirebase();
	
	$rootScope.status = { isopen: false
    					};
	$rootScope.recentlyViewed = [];
	$rootScope.isNavCollapsed = true;
	$rootScope.toggleDropdown = function($event) {
    $event.preventDefault();
    $event.stopPropagation();
    $rootScope.status.isopen = !$rootScope.status.isopen;
    };
	
});

// configure routes
// these are the URLS that map to views/controllers
app.config(function($routeProvider){
	$routeProvider
		// Home Page
		.when('/',{
			templateUrl: 'pages/home.html',
			contoller: 'homeController'
		})
		
		// News Page
		.when('/news',{
			templateUrl: 'pages/news.html',
			contoller: 'newsController'
		})
	
		// Reviews Page
		.when('/reviews',{
			templateUrl: 'pages/reviews.html',
			contoller: 'reviewsController'
		})
	
		// Products Page
		.when('/products',{
			templateUrl: 'pages/products.html',
			controller: 'productsController'
		})
		
		// Product Page
		.when('/product/:productId',{
			templateUrl: 'pages/product.html',
			controller: 'productController'
		})
		
		// Profile Page
		.when('/profile/:userId',{
			templateUrl: 'pages/profile.html',
			controller: 'profileController'
		})
		
		// Settings Page
		.when('/settings',{
			templateUrl: 'pages/settings.html',
			controller: 'settingsController'
		})
	
		// Log-In Page
		.when('/logIn',{
			templateUrl: 'pages/logIn.html',
			controller: 'logInController'
		})
	
		// Registration Page
		.when('/register',{
			templateUrl: 'pages/register.html',
			controller: 'registrationController'
		})
	
		// Account Page
		.when('/account',{
			templateUrl: 'pages/account.html',
			controller: 'accountController'
		})
	
		// Otherwise...if nothing can be located...
		.otherwise({
			templateUrl: 'pages/404.html'
		});
});
// Home Controller
app.controller('homeController', function($scope, $http, $routeParams){
	angular.element(document).ready(function(){
		// 103204 Destiny 2: Forsaken
		// 103054 AC: Odyssey
		// 25076 RDR2
		$http({
			method: 'get',
			url: 'https://api-endpoint.igdb.com/games/',
			headers: {
      			"user-key": app.userKey,
      			Accept: "application/json"
    			},
			params: {
				fields: "name,slug,url,created_at,updated_at,summary,storyline,collection,franchise,hypes,popularity,rating,rating_count,aggregated_rating,aggregated_rating_count,total_rating,total_rating_count,game,version_parent,developers,publishers,game_engines,category,themes,genres,first_release_date,status,screenshots,videos,cover,esrb,games"
			}
		}).then(function(response){ // will be called when response is received
			console.log(response);			
			$scope.stuff = response.data;
		});		
	});
});

// Games Controller
app.controller('NameSearchController', function($scope, $http, $routeParams){
	// look up games using search by name
	$scope.getGames = function(){
		// ajax request to get info
		$http({
			method: 'get',
			url: 'https://api-endpoint.igdb.com/games/',
			headers: {
      			"user-key": app.userKey,
      			Accept: "application/json"
    			},
			params: {
				search: $scope.searchGame,
				fields: "name,slug,url,created_at,updated_at,summary,storyline,collection,franchise,hypes,popularity,rating,rating_count,aggregated_rating,aggregated_rating_count,total_rating,total_rating_count,game,version_parent,developers,publishers,game_engines,category,themes,genres,first_release_date,status,screenshots,videos,cover,esrb,games",
				limit: 6
			}
		}).then(function(response){ // will be called when response is received
			console.log(response);
			
			$scope.games = response.data;
		});
	};
});

// product Controller
app.controller('productController', function($scope, $http, $routeParams){
	angular.element(document).ready(function(){
		// 103204 Destiny 2: Forsaken
		// 103054 AC: Odyssey
		// 25076 RDR2
		$scope.product = $scope.products.find(function(product){
			return product.id == $routeParams.productId;
		});
		
		$http({
			method: 'get',
			url: 'https://api-endpoint.igdb.com/games/' + $scope.product,
			headers: {
      			"user-key": app.userKey,
      			Accept: "application/json"
    			},
			params: {
				fields: "name,slug,url,created_at,updated_at,summary,storyline,collection,franchise,hypes,popularity,rating,rating_count,aggregated_rating,aggregated_rating_count,total_rating,total_rating_count,game,version_parent,developers,publishers,game_engines,category,themes,genres,first_release_date,status,screenshots,videos,cover,esrb,games"
				
			}
		}).then(function(response){ // will be called when response is received
			console.log(response);			
			$scope.stuff = response.data;
		});		
	});
	
});
// News Controller
app.controller('newsController', function($scope, $http, $routeParams){
	$scope.getNews = function(){
		// ajax request to get info
		$http({
			method: 'get',
			url: 'https://api-endpoint.igdb.com/pulses/',
			headers: {
      			"user-key": app.userKey,
      			Accept: "application/json"
    			},
			params: {
				fields: "title,summary,author,uid,image,url",
				limit: 12,
				order: "created_at:desc"
			}
		}).then(function(response){ // will be called when response is received
			console.log(response);
			
			$scope.articles = response.data;
		});
	};
});

// Reviews Controller
app.controller('reviewsController', function($scope, $http, $routeParams){
		$scope.getReviews = function(){
		// set current product user is looking at for product.html 
		// $routeParams.productId will have the product id from the URL
		$scope.review = $scope.product.find(function(id){
			return item.id == $routeParams.productId;
		});
		// ajax request to get info
		$http({
			method: 'get',
			url: 'https://api-endpoint.igdb.com/reviews/',
			headers: {
      			"user-key": app.userKey,
      			Accept: "application/json"
    			},
			params: {
				fields: "username,slug,url,title,game,likes,views,content,positive_points,negative_points",
				"filter[game][eq]": $scope.review,
				limit: 10				
			}
		}).then(function(response){ // will be called when response is received
			console.log(response);
			$scope.reviews = response.data;
		});
	};
});

// Products controller
app.controller('productsController', function($scope, $routeParams){
	// sample products
	// ideally, add image, rating, description, etc to this array
	$scope.products = [	
						{id: 1, name: "Red Dead Redemption 2", image: "images/RDR2PS4.jpg" , price: 24.99, category: "Playstation 4", cat: 2},
						{id: 2, name: "Red Dead Redemption 2", image: "images/RDR2Xbox.jpg" , price: 22.99, category: "Xbox One", cat: 1},
						{id: 3, name: "Red Dead Redemption 2 - Strategy Guide", image: "images/RedDeadGuide.jpg" , price: 23.99, category: "Other", cat: 5},
						{id: 4, name: "Assassin's Creed: Odyssey", image: "images/ACODXbox.jpeg " , price: 21.99, category: "Xbox One", cat: 1},
						{id: 5, name: "Assassin's Creed: Odyssey", image: "images/ACODPS4.jpeg" , price: 25.99, category: "Playstation 4", cat: 2},
						{id: 6, name: "Assassin's Creed: Odyssey", image: "images/ACODPC.jpg" , price: 26.99, category: "PC", cat: 4},
						{id: 7, name: "Super Mario Odyssey", image: "images/Mario.jpg" , price: 24.99, category: "Nintendo Switch", cat: 3},
						{id: 8, name: "Diablo 3 - Switch", image: "images/D3Switch.png" , price: 25.99, category: "Nintendo Switch", cat: 3},
						{id: 9, name: "XenoBlade Chronicles 2", image: "images/XenoBlade.jpg" , price: 26.99, category: "Nintendo Switch", cat: 3},
						{id: 10, name: "World of Warcraft Battle for Azeroth", image: "images/BFAPC.jpg" , price: 24.99, category: "PC", cat: 4},
						{id: 11, name: "Destiny 2 - Forsaken", image: "images/ForsakenGame.jpg" , price: 25.99, category: "Playstation 4", cat: 2},
						{id: 12, name: "Destiny 2 - Forsaken", image: "images/ForsakenGame.jpg" , price: 26.99, category: "Xbox One", cat: 1}
					];
	
	$scope.productCategory = '';

	$scope.slides = [
						{
						image: 'images/RDR2Art.png', 
						image2: 'images/RedDead2.jpg', 
						name: 'Red Dead Redemption 2', 
						text: 'Developed by the creators of Grand Theft Auto V and Red Dead Redemption, Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game\'s vast and atmospheric world will also provide the foundation for a brand new online multiplayer experience.', 
						id: 0, 
						productId: 25076
						},
						{
						image: 'images/ACOdysseyArt.jpg', 
						image2: 'images/Odyssey.jpg', 
						name: 'Assassins Creed: Odyssey', 
						text: 'Write your own epic odyssey and become a legendary Spartan hero in Assassin\'s Creed Odyssey, an inspiring adventure where you must forge your destiny and define your own path in a world on the brink of tearing itself apart. Influence how history unfolds as you experience a rich and ever-changing world shaped by your decisions.',
						id: 1, 
						productId: 103054
						},
						{
						image: 'images/D2ForsakenArt.jpg', 
						image2: 'images/Forsaken.jpeg', 
						name: 'Destiny 2: Forsaken', 
						text: 'Take justice into your own hands as you venture into a new frontier filled with enemies, allies, untold mysteries, and treasures waiting to be uncovered.', 
						id: 2, 
						productId: 103204}
					];
	
	$scope.changeCategory = function(category){
		
		if($scope.productCategory === category){
			$scope.productCategory = '';
		}else {
			$scope.productCategory = category;
		}
	};
	
});

app.controller('authCtrl', function($scope, $firebaseAuth, $firebaseObject){
	// initalize database
	app.initFirebase();
	
	// initialize auth object
	$scope.authObj = $firebaseAuth();
	
	// store user objects
	$scope.authUser = null; // authenticated user object
	$scope.user = null; // our user's details or record
	
	// on login or logout
	$scope.authObj.$onAuthStateChanged(function(firebaseUser) {
	  if (firebaseUser) {
		console.log("Signed in as:", firebaseUser.uid);
		  $scope.authUser = firebaseUser;
		  $scope.user = $firebaseObject(app.firebaseRef
									   .child('users')
									   .child($scope.authUser.uid));
		  // Same as
		  // $scope.user = $firebaseObject(app.firebaseRef.child('users/'+ $scope.authUser.uid));
	  } else {
		console.log("Signed out");
		  $scope.authUser = null;
		  $scope.user = null;
	  }
	});	
	
	// button methods
	$scope.createUser = function(userName, password){
		// get values from the form
		
		// create user - pass username and password to this method
		$scope.authObj.$createUserWithEmailAndPassword(userName, password)
		  .then(function(firebaseUser) {
			console.log("User " + firebaseUser.uid + " created successfully!");
		  }).catch(function(error) {
			console.error("Error: ", error);
		  });
		// ...
	};
	
	$scope.login = function(userName, password){
		// get values from the form
		$scope.
		// validate input
		
		// login - pass username and password to this method
		$scope.authObj.$signInWithEmailAndPassword(userName, password).then(function(firebaseUser) {
		  console.log("Signed in as:", firebaseUser.uid);
		}).catch(function(error) {
		  console.error("Authentication failed:", error);
		});
	};
	
	$scope.updateUser = function(){
		// validate the form
		
		// create data (from a form) to store with use
		
		// store data with user
		// stores in /users/lkada9ae89slsekljklse/firstname = "Tyler"
		app.firebaseRef.child('users').child($scope.authUser.uid).update(data);
	};
	
	$scope.logout = function(){
		// sign out
		$scope.user.$destroy();
		$scope.authObj.$signOut();
	};
	
}); // end authCtrl

app.initFirebase = function(){
	
// Initialize Firebase
  var config = {
    // You will need to supply your personal Firebase Key here
    apiKey: "{Insert Your Firebase API Key Here}",
    authDomain: "{Insert Your Firebase Domain Name Here}",
    databaseURL: "{Insert Your Firebase URL Here}",
    projectId: "{Insert Your Firebase ProjectID Here}",
    storageBucket: "{Insert Your Firebase Storage Here}",
    messagingSenderId: "{Insert Your Firebase SenderID Here}"
    // Example: apiKey: "MYMAGICALFIREBASEKEY123",
		authDomain: "gaming-site-jjs.firebaseapp.com",
    // 		databaseURL: "https://gaming-site-jjs.firebaseio.com",
    //  	projectId: "gaming-site-jjs",
    // 		storageBucket: "gaming-site-jjs.appspot.com",
    //		messagingSenderId: "570053019655"
  };
  firebase.initializeApp(config);
	
  // create database reference to root
  app.firebaseRef = firebase.database().ref('/');
};
