import {
  faGithub,
  faInstagram,
  faLinkedin,
} from "@fortawesome/free-brands-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { useState } from "react";

const SideBar = () => {
  const [hoveredLinkedin, setHoveredLinkedin] = useState(false);
  const [hoveredGithub, setHoveredGithub] = useState(false);
  const [hoveredInstagram, setHoveredInstagram] = useState(false);

  const iconLinkedinHoveredHandler = () => {
    setHoveredLinkedin(!hoveredLinkedin);
  };

  const iconGithubHoveredHandler = () => {
    setHoveredGithub(!hoveredGithub);
  };

  const iconInstagramHoveredHandler = () => {
    setHoveredInstagram(!hoveredInstagram);
  };

  return (
    <aside className="fixed flex top-0 h-screen items-center">
      <ul className="flex flex-col items-center">
        <li className="m-5">
          <a
            href="https://www.linkedin.com/in/felipe-berlini-a6013790/"
            target="_blank"
            rel="noreferrer"
          >
            <FontAwesomeIcon
              icon={faLinkedin}
              size="2xl"
              onMouseEnter={iconLinkedinHoveredHandler}
              onMouseLeave={iconLinkedinHoveredHandler}
              className={hoveredLinkedin ? "fa-bounce" : ""}
            />
          </a>
        </li>
        <li className="m-5">
          <a
            href="https://github.com/fberlini"
            target="_blank"
            rel="noreferrer"
          >
            <FontAwesomeIcon
              icon={faGithub}
              size="2xl"
              onMouseEnter={iconGithubHoveredHandler}
              onMouseLeave={iconGithubHoveredHandler}
              className={hoveredGithub ? "fa-bounce" : ""}
            />
          </a>
        </li>
        <li className="m-5">
          <a
            href="https://www.instagram.com/felipeberlini/"
            target="_blank"
            rel="noreferrer"
          >
            <FontAwesomeIcon
              icon={faInstagram}
              size="2xl"
              onMouseEnter={iconInstagramHoveredHandler}
              onMouseLeave={iconInstagramHoveredHandler}
              className={hoveredInstagram ? "fa-bounce" : ""}
            />
          </a>
        </li>
      </ul>
    </aside>
  );
};

export default SideBar;
