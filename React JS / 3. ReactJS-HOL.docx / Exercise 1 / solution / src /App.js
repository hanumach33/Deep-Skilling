import CalculateScore from "./Components/CalculateScore";

function App() {
    return (
        <div>
            <CalculateScore
                Name="Rahul"
                School="ABC Public School"
                Total={480}
                Goal={500}
            />
        </div>
    );
}

export default App;
