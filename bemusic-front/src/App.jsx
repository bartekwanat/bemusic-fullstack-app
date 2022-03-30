import React from 'react';
import { Routes, Route } from 'react-router-dom';
import Login from "./components/Login/Login";
import './index.css';
import Register from "./components/Register/Register";
import Layout from "./components/Layout";
import RequireAuth from "./components/RequireAuth";
import Home from "./components/Home/Home"




function App() {
    return (

        <Routes>
            <Route path="/" element={<Layout />}>

                <Route path="/login" element={<Login />}/>
                <Route path="/register" element={<Register />}/>
                <Route path="/" element={<Home />}/>
                <Route element={<RequireAuth/>}>

                </Route>
            </Route>
        </Routes>
    );
}

export default App;
