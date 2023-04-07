import logo from './logo.svg';
import './MainPage.css';
function MainPage() {
    return ( 
        <main>
        <div 
        className='hello'
        >
        <h1>Добро пожаловать</h1>
        <p>На данный момент идёт перенос сайта на React.JS</p>
        </div>
        <div>
            <h2>Что планируется?</h2>
            <p><i className="fa fa-cogs" aria-hidden="true"></i> Данное нововведение позволит повысить качество работы сайта и обеспечить новые функции.</p>
            <p><i className="fa fa-paint-brush" aria-hidden="true"></i>Динаминчный контент будет оформлен в собственном UI интерфейсе</p>
            <h3>Новая система ограничений</h3>
            <p><i className="fa fa-ban" aria-hidden="true"></i> Планируется новая система ораничений, которая позволит работать с пользователями более детально</p>
        </div>
        </main>
    );
}


export default MainPage;