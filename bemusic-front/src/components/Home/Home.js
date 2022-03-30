import {React, useContext, useState, useEffect, useRef} from "react";
import {Link, useLocation, useNavigate} from "react-router-dom";
import { useMediaQuery } from 'react-responsive'
import  {FontAwesomeIcon}  from "@fortawesome/react-fontawesome";
import {faSearch, faSignOutAlt, faList, faChevronCircleDown} from "@fortawesome/free-solid-svg-icons";

import {axiosPrivate} from "../../api/axios";
import "./Home.scss";

import AuthContext from "../../context/AuthProvider";

import useAuth from "../../hooks/useAuth";




 const Home = () => {
     const { auth } = useAuth();
     const { setAuth } = useContext(AuthContext);
     const navigate = useNavigate();
     const location = useLocation();
     const searchRef = useRef();

     const token = localStorage.getItem('token');

     const [albums, setAlbums] = useState('');
     const [searchPhrase, setSearchPhrase] = useState('');
     const [isOpen, setIsOpen] = useState(false);
     let trackNumber = 3;




     useEffect(() => {
         searchRef.current.focus();
     }, []);



     useEffect(() => {
        let isMounted = true;
        const controller = new AbortController();
         console.log(searchPhrase);

         const getAlbums = async () => {
            try {

                const response = await axiosPrivate.get(`/album?searchPhrase=${searchPhrase}`, {
                    headers : {
                        'Authorization' : `${token}`
                    }
                });
                console.log(response.data);
                console.log(auth);
                isMounted && setAlbums(response.data);
                console.log(searchPhrase);
            } catch (e) {
                console.log(e);
                navigate('/login', {state: {from: location}, replace: true})
            }
        }
        getAlbums();

        return () => {
            isMounted = false;
            controller.abort();
        }
     }, [searchPhrase])

    const logout = async () => {
        setAuth({});
        navigate('/login');
    }

    const handleToggle = (index) => {
        document.getElementById(`album${index}`).classList.toggle("album-wrapper--full");
        document.getElementById(`tracklist-wrapper${index}`).classList.toggle("tracklist-wrapper--full");
        document.getElementById(`arrow${index}`).classList.toggle("turned");
        console.log(trackNumber)
     };

    const isPhone = useMediaQuery({query: '(max-width: 500px)' })

    return(

        <section className="home-wrapper">

            {/*HEADER*/}
            <header>
                <img src={require('../../assets/logo2.png')} className="logo" alt="brand-logo"/>

                <form  className="search">
                    <input type="text"
                           placeholder="Search..."
                           ref={searchRef}
                           onChange={(e) => setSearchPhrase(e.target.value)}
                           value={searchPhrase}
                    />
                    <button className="search-button">
                        <FontAwesomeIcon icon={faSearch} />
                    </button>
                </form>

                <div className="logout">
                    {!isPhone && <button onClick={logout} className="logout">Logout</button>}
                    {isPhone && <FontAwesomeIcon icon={faSignOutAlt} onClick={logout}/>}
                </div>
            </header>

           {/* HEADER END*/}

            {/*LIST CONTAINER*/}
            <header className="column-header">
                <ul className="column-header--list">
                    <li>#</li>
                    <li>Title</li>
                    <li>Artist</li>
                    <li>Year</li>
                    <li>Duration</li>
                </ul>
            </header>
            <article className="content-wrapper">

                {albums?.length
                ? (

                    <ul className="list-wrapper">

                        {albums.map((album) =>

                               <section
                                   key={album.id}
                                   id={`album${album.id}`}
                                   className={"album-wrapper"}
                                   onClick={() => handleToggle(album.id)}
                                   >
                                   <div className="album">
                                    <img src={require('../../assets/album.png')} className="album-avatar" alt="brand-logo"/>

                                   <ul className="album-info">
                                       <li  className="album-title">{album?.title} &nbsp;
                                            <span  className="album-year">({album?.releaseYear})</span>
                                       </li>
                                       <li  className="album-artist">{album?.artistName}</li>
                                       <li  className="album-version">{album?.version}</li>
                                   </ul>
                                   </div>

                                   <ul  id={`tracklist-wrapper${album.id}`}
                                        className={"tracklist-wrapper"}>

                                       {album.tracks.map((track, i) =>
                                       <ul
                                           id={`tracklist${album.id}`}
                                           className="tracklist">
                                           <li key={i}>{i + 1}</li>
                                           <li >{track?.artistName}</li>
                                           <li >{track?.title}</li>
                                           <li>{track?.releaseYear}</li>
                                           <li>{track?.duration}</li>
                                       </ul>

                                           )}

                                   </ul>
                                   <FontAwesomeIcon
                                       icon={faChevronCircleDown}
                                       id={`arrow${album.id}`}
                                       className="arrow" />

                               </section>

                        )
                        }
                    </ul>


                    ) : <p>Albums list is empty.</p>
                }
            </article>


        </section>
    );
}

export default Home;