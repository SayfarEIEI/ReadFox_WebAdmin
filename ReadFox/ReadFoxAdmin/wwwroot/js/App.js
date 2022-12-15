function App() {
    fetch("https://localhost:5001/Provinces")
        .then((res) => res.json())
        .then((json) => {
            setResult(json);
            console.log(json);
        })
}