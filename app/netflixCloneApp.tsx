import React from "react";
import { Button } from "./material-tailwind";
import { SignUp } from "../components/SignUp";
import hero from "../public/hero.jpg";

const NetflixCloneApp = () => {
  return (
    <div className="dark relative min-h-screen w-full bg-[url('/newHero.jpeg'] bg-no-repeat bg-fixed bg-center bg-cover">
      <img
        src="/hero.jpg"
        alt="hero test"
        className="bg-no-repeat bg-fixed bg-center bg-cover -z-10 absolute"
      />
      <div className=" min-h-screen w-full bg-opacity-50">
        <nav className="px-12 py-5">
          <img
            src="/logo.png"
            alt="netflix-logo"
            className="h-20 mt-12 mb-20"
          />
        </nav>
        <div className="flex justify-center">
          <div className="bg-black bg-opacity-75 py-7 px-12 border-4 rounded-lg border-black">
            <SignUp />
          </div>
        </div>
      </div>
    </div>
  );
};

export default NetflixCloneApp;
