import ListOfPlayers from "./ListOfPlayers";
import IndianPlayers from "./IndianPlayers";

function App() {

    const flag = true;

    if (flag) {

        return <ListOfPlayers />;

    } else {

        return <IndianPlayers />;

    }

}

export default App;
