"use client";

import Link from "next/link";
import React, { useEffect, useState } from "react";

const Navbar = () => {
  const [scrolled, setScrolled] = useState<boolean>(false);

  useEffect(() => {
    window.addEventListener("scroll", handleScroll);
    return () => {
      window.removeEventListener("scroll", handleScroll);
    };
  }, []);

  const handleScroll = () => {
    if (window.scrollY > 50) {
      setScrolled(true);
    } else {
      setScrolled(false);
    }
  };

  return (
    <div
      className={`${
        !scrolled ? "bg-gradient-to-b from-black to-transparent" : "bg-black"
      } p-4 h-screen mb-32`}
    >
      <nav className="flex items-start justify-between fixed top-0 left-0">
        <div className="flex items-center space-x-4">
        <img src="/logo.png" alt="Netflix Logo" className="h-10" />
          <Link href="/HomePage" className="text-white hover:text-gray-300">
            Startseite
          </Link>
          <Link href="#" className="text-white hover:text-gray-300">
            Serien
          </Link>
          <Link href="#" className="text-white hover:text-gray-300">
            Filme
          </Link>
          <Link href="#" className="text-white hover:text-gray-300">
            Games
          </Link>
          <Link href="#" className="text-white hover:text-gray-300">
            Neu und beliebt
          </Link>
          <Link href="#" className="text-white hover:text-gray-300">
            Meine Liste
          </Link>
          <Link href="#" className="text-white hover:text-gray-300">
            Nach Sprachen durchsuchen
          </Link>
        </div>
        <div className="flex items-center justify-end">
          <Link href="#" className="text-white hover:text-gray-300">
            search
          </Link>
        </div>
      </nav>
    </div>
  );
};

export default Navbar;
