function App() {

    const offices = [

        {
            name: "Tech Park",
            rent: 45000,
            address: "Hyderabad",
            image: "https://via.placeholder.com/300x200"
        },

        {
            name: "Cyber Towers",
            rent: 70000,
            address: "Bangalore",
            image: "https://via.placeholder.com/300x200"
        },

        {
            name: "Business Hub",
            rent: 55000,
            address: "Chennai",
            image: "https://via.placeholder.com/300x200"
        }

    ];

    return (

        <div style={{ margin: "20px", fontFamily: "Arial" }}>

            <h1>Office Space Rental App</h1>

            {

                offices.map((office, index) => (

                    <div
                        key={index}
                        style={{
                            border: "1px solid gray",
                            padding: "15px",
                            marginBottom: "20px",
                            width: "350px"
                        }}
                    >

                        <img
                            src={office.image}
                            alt={office.name}
                            width="300"
                            height="200"
                        />

                        <h2>{office.name}</h2>

                        <h3
                            style={{
                                color:
                                    office.rent < 60000
                                        ? "red"
                                        : "green"
                            }}
                        >
                            Rent : ₹ {office.rent}
                        </h3>

                        <p>
                            <strong>Address :</strong> {office.address}
                        </p>

                    </div>

                ))

            }

        </div>

    );

}

export default App;
