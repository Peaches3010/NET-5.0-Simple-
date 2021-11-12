import React from "react";
import { Table } from "reactstrap";
import { BsCheck } from "@react-icons/all-files/bs/BsCheck";
import { IoCloseSharp } from "@react-icons/all-files/io5/IoCloseSharp";
import "./home.css";
import { MdSettingsBackupRestore } from "@react-icons/all-files/md/MdSettingsBackupRestore";
// import './Home.css'
function Home() {
  return (
    <div className="home">
      <h5 className="right-title">All Produts</h5>
      <Table>
        <thead>
          <tr>
            <th>Product Name</th>
            <th>Category</th>
            <th>Assigned Date</th>
            <th>Descsciption</th>
            <th>Price</th>
            <th>Cost</th>
            <th>IsFeatured</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <th scope="row">1</th>
            <td>Otto</td>
            <td>@mdo</td>
            <td>@mdo</td>
            <td>@mdo</td>
            <td>@mdo</td>
            <td>@mdo</td>
            <td>
              <span className="icon-nash icon-nash--red">
                <IoCloseSharp />
              </span>
              <span className="icon-nash icon-nash--black">
                <BsCheck />
              </span>
              <span className="icon-nash icon-nash--blue">
                <MdSettingsBackupRestore />
              </span>
            </td>
          </tr>
        </tbody>
      </Table>
    </div>
  );
}

export default Home;
