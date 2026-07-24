import { useState } from "react";
import ThemeContext from "./ThemeContext";
import EmployeesList from "./EmployeesList";

function App() {

    const [theme] = useState("light");

    const employees = [

        {
            id: 1,
            name: "John Doe",
            designation: "Software Engineer"
        },

        {
            id: 2,
            name: "Alice Smith",
            designation: "Senior Developer"
        },

        {
            id: 3,
            name: "David Johnson",
            designation: "Project Manager"
        }

    ];

    return (

        <ThemeContext.Provider value={theme}>

            <div>

                <h1>Employee Management</h1>

                <EmployeesList employees={employees} />

            </div>

        </ThemeContext.Provider>

    );

}

export default App;
