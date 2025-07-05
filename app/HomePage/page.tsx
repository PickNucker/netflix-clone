import Navbar from "@/components/Navbar";
import React from "react";

const page = () => {
  return (
    <>
      <Navbar/>
      <div className=""></div>
      <div className="">
        <img src={"/poster.png"} alt="default" className="h-screen" ></img>
        <h1>Die beste Medizin gegen Langweile</h1>
      </div>
    </>
  );
};

export default page;
