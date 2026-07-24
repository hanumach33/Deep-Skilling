function ListOfPlayers() {

    const players = [
        { name: "Virat Kohli", score: 92 },
        { name: "Rohit Sharma", score: 85 },
        { name: "KL Rahul", score: 65 },
        { name: "Shubman Gill", score: 78 },
        { name: "Hardik Pandya", score: 69 },
        { name: "Ravindra Jadeja", score: 88 },
        { name: "R Ashwin", score: 58 },
        { name: "Jasprit Bumrah", score: 72 },
        { name: "Mohammed Shami", score: 60 },
        { name: "Mohammed Siraj", score: 55 },
        { name: "Kuldeep Yadav", score: 74 }
    ];

    const filteredPlayers = players.filter(
        player => player.score < 70
    );

    return (

        <div>

            <h2>List of Players</h2>

            <ul>

                {
                    players.map((player, index) => (

                        <li key={index}>
                            {player.name} - {player.score}
                        </li>

                    ))
                }

            </ul>

            <h2>Players with Score Below 70</h2>

            <ul>

                {
                    filteredPlayers.map((player, index) => (

                        <li key={index}>
                            {player.name} - {player.score}
                        </li>

                    ))
                }

            </ul>

        </div>

    );

}

export default ListOfPlayers;
