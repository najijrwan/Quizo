import { Link, NavLink } from 'react-router-dom'
import { useState } from 'react'

export default function Navbar() {

  const categories = ["cat1", "cat2", "cat3", "cat4", "cat5", "cat6"];

  return (
    <>
      <nav className="relative bg-[#84C7D0] px-4 py-3 flex items-center justify-center text-[#343330]">
        <Link to="/" className="font-bold text-xl absolute left-5 ">Omnia</Link>

        <div className='w-[50%] relative flex justify-center items-center'>
          <input
            type="text"
            placeholder='What do you wish to find ?'
            className='bg-white rounded-[5px] p-2 w-full'
          />
          <button className='absolute right-0 bg-[#3E8989] h-full rounded-tr-[5px] rounded-br-[5px] px-1.5 text-white'>Find</button>
        </div>
        <div className='absolute right-5 flex justfiy-end flex-row-reverse items-center gap-5'>
          <Link to="registration" className='text-lg p-2 rounded-[5px] bg-white hover:opacity-80'>Sign Up</Link>
          <Link to="Cart">Cart</Link>
          <Link to="Cart">Favorites</Link>
        </div>
      </nav>
      <nav className='bg-[#75DDDD] text-white flex justify-center items-center gap-5 py-2'>
        {categories.map((category) => (
          <NavLink
            key={category}
            to={`/products?category=${category}`} // or whatever route you want
            className={({ isActive }) =>
              isActive ? "font-bold underline" : "hover:underline"
            }
          >
            {category}
          </NavLink>
        ))}
      </nav>
    </>

  )
}
