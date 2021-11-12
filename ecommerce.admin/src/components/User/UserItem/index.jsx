import React from "react";
import { IoMdCreate } from "@react-icons/all-files/io/IoMdCreate";
import { IoIosCloseCircleOutline } from "@react-icons/all-files/io/IoIosCloseCircleOutline";

function usersItem(props) {
  let { users } = props;

  return (
    <tr>
      {/* <th scope="row">{users.staffcode}</th> */}
      <td>{users.Fullname}</td>
      <td>{users.usersname}</td>
      <td>{users.Email}</td>
      <td>{users.PhoneNumber}</td>
      <td>
        <span className="icon-nash icon-nash--black">
          <IoMdCreate />
        </span>
        <span className="icon-nash icon-nash--red">
          <IoIosCloseCircleOutline />
        </span>
      </td>
    </tr>
  );
}

export default usersItem;
