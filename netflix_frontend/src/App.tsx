import React, { useEffect, useState } from "react";

import "./output.css";
import { Weather } from "./types/Weather";
import WeatherComp from "./components/Weather";


function App() {
  const [data, setData] = useState<Weather[]>([]);

  useEffect(() => {
    fetch("http://localhost:5226/weatherforecast/")
      .then((res) => {
        if (!res.ok) throw new Error(`Status ${res.status}`);
        return res.json();
      })
      .then((data) => {
        setData(data);
        console.log("API Data:", data);
      })
      .catch((err) => console.error("Fehler beim API Call:", err));
  }, []);

  return (
    <div className="App text-2xl font-extrabold">
      <span className="font-bold text-xl">Wetter:</span>
      <WeatherComp weatherData={data}/>
    </div>
  );
}

export default App;
