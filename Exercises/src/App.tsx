import { Route, Routes } from 'react-router-dom'
import Exercise1 from './components/exercise1';
import Exercise2 from './components/exercise2';
import Exercise3 from './components/exercise3';
import Exercise4 from './components/exercise4';
import Exercise5 from './components/exercise5';
import Exercise6 from './components/exercise6';
import NavBar from './components/navBar';
import './App.css';

function App() {
  return (
    <div className="App">
      <NavBar/>

      <Routes>
        <Route path='/' element={<Exercise1/>}></Route>
        <Route path='/exercise2' element={<Exercise2/>}></Route>
        <Route path='/exercise3' element={<Exercise3/>}></Route>
        <Route path='/exercise4' element={<Exercise4/>}></Route>
        <Route path='/exercise5' element={<Exercise5/>}></Route>
        <Route path='/exercise6' element={<Exercise6/>}></Route>
      </Routes>

    </div>
  );
}

export default App;
