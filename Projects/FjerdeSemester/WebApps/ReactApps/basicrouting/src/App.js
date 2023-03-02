import React from "react"
import { Routes, Route, Link } from "react-router-dom"
import Home from "./Home"
import NotFound from "./NotFound"
import Page2 from "./Page2"
import Page3 from "./Page3"
import Page4 from "./Page4"

const App = () => (
    <>
    <nav>
        <Link to="/">Home</Link><br/>
        <Link to="/page2">Page2</Link><br/>
        <Link to="/page3">Page3</Link><br/>
        <Link to="/page4/4">Page4</Link>
    </nav>
    <Routes>
        <Route path="/" element={<Home/>} />
        <Route path="/page2" element={<Page2/>} />
        <Route path="/page3" element={<Page3/>} />
        <Route path="/page4/:id" element={<Page4/>} />
        <Route path="*" element={<NotFound/>} />
    </Routes>
    </>
)

export default App