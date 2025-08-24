import React from 'react'

import { FilmData } from '../types/FilmData';

const Film : React.FC<{filmData : FilmData[]}> = (props) => {
  return (
    <div>
      {props.filmData.map((film) => (
        <div key={film.id}>
          <h2>{film.title}</h2>
          <p>{film.description}</p>
          <p>Genre: {film.genre}</p>
          <p>Release Date: {film.releaseDate}</p>
          <p>Rating: {film.rating}</p>
        </div>
      ))}
    </div>
  )
}

export default Film