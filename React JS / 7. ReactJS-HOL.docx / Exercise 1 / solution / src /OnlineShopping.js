import React, { Component } from "react";
import Cart from "./Cart";

class OnlineShopping extends Component {

    constructor(props) {

        super(props);

        this.items = [

            { itemName: "Laptop", price: 65000 },

            { itemName: "Mouse", price: 900 },

            { itemName: "Keyboard", price: 1800 },

            { itemName: "Headphones", price: 2500 },

            { itemName: "Monitor", price: 15000 }

        ];

    }

    render() {

        return (

            <div>

                <h2>Online Shopping Cart</h2>

                <table border="1" cellPadding="10">

                    <thead>

                        <tr>

                            <th>Item Name</th>

                            <th>Price</th>

                        </tr>

                    </thead>

                    <tbody>

                        {

                            this.items.map((item, index) => (

                                <Cart
                                    key={index}
                                    itemName={item.itemName}
                                    price={item.price}
                                />

                            ))

                        }

                    </tbody>

                </table>

            </div>

        );

    }

}

export default OnlineShopping;
