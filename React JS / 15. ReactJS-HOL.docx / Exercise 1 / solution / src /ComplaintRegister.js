import React, { Component } from "react";

class ComplaintRegister extends Component {

    constructor(props) {

        super(props);

        this.state = {

            employeeName: "",
            complaint: "",
            referenceNumber: Math.floor(
                100000 + Math.random() * 900000
            )

        };

    }

    handleChange = (event) => {

        this.setState({

            [event.target.name]: event.target.value

        });

    };

    handleSubmit = (event) => {

        event.preventDefault();

        alert(
            "Thanks " +
            this.state.employeeName +
            "\nYour Complaint was submitted.\nReference Number: " +
            this.state.referenceNumber
        );

    };

    render() {

        return (

            <div style={{ margin: "30px" }}>

                <h1 style={{ color: "red" }}>
                    Register your complaints here!!!
                </h1>

                <form onSubmit={this.handleSubmit}>

                    <label>Name :</label>

                    <input
                        type="text"
                        name="employeeName"
                        value={this.state.employeeName}
                        onChange={this.handleChange}
                    />

                    <br /><br />

                    <label>Complaint :</label>

                    <textarea
                        name="complaint"
                        value={this.state.complaint}
                        onChange={this.handleChange}
                    />

                    <br /><br />

                    <button type="submit">
                        Submit
                    </button>

                </form>

            </div>

        );

    }

}

export default ComplaintRegister;
