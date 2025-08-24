import React, { useEffect, useState } from "react";

import "./output.css";
import Film from "./components/Film";
import { FilmData } from "./types/FilmData";


function App() {
  const [data, setData] = useState<FilmData[]>([]);
  const [film, setFilm] = useState<FilmData | null>(null);

  useEffect(() => {
    fetch("/api/FilmEntry/4")
      .then((res) => {
        if (!res.ok) throw new Error(`Status ${res.status}`);
        return res.json();
      })
      .then((data) => {
        setFilm(data);
        console.log("API Data:", data);
      })
      .catch((err) => console.error("Fehler beim API Call:", err));
  }, []);

  return (
    <div className="App text-2xl font-extrabold">
      <span className="font-bold text-xl">Filme:</span>
       {/* <Film filmData={data} /> */}
       {film?.title}
    </div>
  );
}

export default App;
