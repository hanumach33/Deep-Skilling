import React, { Component } from "react";

class Register extends Component {

    constructor(props) {

        super(props);

        this.state = {

            name: "",
            email: "",
            password: "",
            errors: {}

        };

    }

    handleChange = (event) => {

        this.setState({

            [event.target.name]: event.target.value

        });

    };

    validate = () => {

        let errors = {};

        let valid = true;

        if (this.state.name.length < 5) {

            errors.name =
                "Name should have at least 5 characters";

            valid = false;

        }

        if (
            !this.state.email.includes("@") ||
            !this.state.email.includes(".")
        ) {

            errors.email =
                "Invalid Email";

            valid = false;

        }

        if (this.state.password.length < 8) {

            errors.password =
                "Password should have at least 8 characters";

            valid = false;

        }

        this.setState({

            errors: errors

        });

        return valid;

    };

    handleSubmit = (event) => {

        event.preventDefault();

        if (this.validate()) {

            alert("Registration Successful");

        }

    };

    render() {

        return (

            <div style={{ margin: "30px" }}>

                <h2>Mail Registration</h2>

                <form onSubmit={this.handleSubmit}>

                    <label>Name</label>

                    <br />

                    <input
                        type="text"
                        name="name"
                        value={this.state.name}
                        onChange={this.handleChange}
                    />

                    <br />

                    <span style={{ color: "red" }}>
                        {this.state.errors.name}
                    </span>

                    <br /><br />

                    <label>Email</label>

                    <br />

                    <input
                        type="email"
                        name="email"
                        value={this.state.email}
                        onChange={this.handleChange}
                    />

                    <br />

                    <span style={{ color: "red" }}>
                        {this.state.errors.email}
                    </span>

                    <br /><br />

                    <label>Password</label>

                    <br />

                    <input
                        type="password"
                        name="password"
                        value={this.state.password}
                        onChange={this.handleChange}
                    />

                    <br />

                    <span style={{ color: "red" }}>
                        {this.state.errors.password}
                    </span>

                    <br /><br />

                    <button type="submit">
                        Register
                    </button>

                </form>

            </div>

        );

    }

}

export default Register;
