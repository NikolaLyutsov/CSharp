function solve(){
    class Product {
        constructor(productType, name, price){
            this._productType = productType;
            this._name = name;
            this._price = price;
        }
        get producType(){
            return this._productType;
        }
        get name(){
            return this._name;
        }
        get price(){
            return this._price;
        }
    }
    
    class ShoppingCart {
        constructor(){
            this._products = [];
        }
        get products(){
            return this._products;
        }

        add(product){
            products.push(product);
            return this;
        }

        remove(product){
            const index = products.findIndex(p => p.name === product.name && p.productType === product.productType && p.price === product.price);
            if(index < 0){
                throw 'Product not found';	
            }
            products.splice(index, 1);
            return this;
        }

         showCost(){
            let cost = 0;
            for (const product of products) {
                cost += product.price;
            }
            return cost;
        }

         showProductTypes(){
            // const uniqTypes =[];
            // for (const p of products) {
            // 	if(uniqTypes.indexOf(p.productType) < 0){
            // 		uniqTypes.push(p.productType);
            // 	}
            // }
            // return uniqTypes.sort();

            const uniqTypesObj = {};
            products.forEach(p => uniqTypesObj[p.productType] = true);
            return Object.keys(uniqTypesObj).sort();
        }

         getInfo(){

            const uniqNames = products.map(p => p.name).sort().filter((p, i, ps) => i === 0 || p !== ps[i-1])
            .map(name => {
                const whitThisName = products.filter(p => p.name === name);
                return {
                    name: name,
                    quantity: whitThisName.length,
                    totalPrice: whitThisName.reduce((cost, product) => cost + product.price, 0)
                }
            });


        return {
            products: uniqNames,
            totalPrice: showCost()
        }
        };
    }
    
    
    
        function getProduct(productType, name, price){
            return{ 
                productType: productType,
                name: name,
                price: price
            };
        }
    
        function getShoppingCart(){
    
    
        return{
            products: products,
            add: add,
            remove: remove,
            showCost: showCost,
            showProductTypes: showProductTypes,
            getInfo: getInfo
        };
        }
        return {
            Product: getProduct,
            ShoppingCart: ShoppingCart
        };
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // function solve() {
    // 	class Product{
    // 		constructor (productType, name, price){
    // 			this._producType = productType;
    // 			this._name = name;
    // 			this._price = price;
    
    // 		}
    // 		get: productType() {
    // 			return 'string';
    // 		};
    
    // 		get: name(){
    // 			return string;
    // 		}
    
    // 		get price(){
    // 			return Number;
    // 		}
    // 	}
    
    // 	class ShoppingCart{
    // 			constructor(){
    
    // 			}
    
    // 			get: products(){
    // 				if(products !== 'Array'){
    // 					return new Error('nah');
    // 				}
    // 			}
    // 			let products = [];
    // 	function add(Product){
    // 		products.push(product);
    // 	}
    // };
    
        
    // 	return {
    // 		Product, ShoppingCart
    // 	};
    // }
    
    module.exports = solve();