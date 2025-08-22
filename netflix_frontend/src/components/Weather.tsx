import React from 'react'
import  { Weather }  from '../types/Weather';

const WeatherComp: React.FC<{weatherData: Weather[]}> = (props) => {
  return (
    <ul>
        {props.weatherData.map(data => (
            <>
                <h1>{data.date}</h1>
                <li>tempC: {data.temperatureC}</li>
                <li>tempF: {data.temperatureF}</li>
                <li>Summary: {data.summary}</li>
            </>
        ))}
    </ul>
  )
}

export default WeatherComp;