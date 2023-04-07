import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import MainPage from './MainPage';
import ErrorPage from './ErrorPage';
import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(document.getElementById('root'));

switch(window.location.pathname){
  case("/"): active(<MainPage />); break;
  default: active(<ErrorPage />); break;
}

function active(asd){
  root.render(
    <React.StrictMode>
    {asd}
  </React.StrictMode>
  );
}

reportWebVitals();
