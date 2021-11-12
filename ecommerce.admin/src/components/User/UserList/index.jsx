import React from "react";
import { AiOutlineSearch } from "@react-icons/all-files/ai/AiOutlineSearch";
import { AiFillFilter } from "@react-icons/all-files/ai/AiFillFilter";
import { IoMdCreate } from "@react-icons/all-files/io/IoMdCreate";
import { IoIosCloseCircleOutline } from "@react-icons/all-files/io/IoIosCloseCircleOutline";
import { Link } from "react-router-dom";

import {
  Col,
  Row,
  Button,
  InputGroupText,
  FormGroup,
  InputGroupAddon,
  Input,
  InputGroup,
} from "reactstrap";
import { Table } from "reactstrap";
import "./UserList.css";

function UserList(props) {
  const { stateList } = props;
  const { paging, setPaging } = props;
  const [tempPaging, setTempPaging] = useState(paging);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setTempPaging({ ...tempPaging, [name]: value });
  };

  return (
    <div>
      <h5 className="right-title">User List</h5>
      <Row from>
        <Col md={3}>
          <InputGroup>
            <select
              className="custom-select custom-select-lg mb-3"
              className="form-control"
            >
              <option selected>Type</option>
              <option value={0}></option>
              <option value={1}>Staff</option>
              <option value={2}>Customer</option>
            </select>

            <InputGroupText className="right__icon">
              <AiFillFilter />
            </InputGroupText>
          </InputGroup>
        </Col>
        {/* <InputGroupText className="right__icon">
                <AiFillFilter />
              </InputGroupText> */}
        <Col md={3}>
          <InputGroup>
            <Input placeholder="Search" />
            <InputGroupAddon addonType="append">
              <InputGroupText className="right__icon">
                <AiOutlineSearch />
              </InputGroupText>
            </InputGroupAddon>
          </InputGroup>
        </Col>
        <Col md={6} className="text-right">
          <Button color="danger">
            <Link to="/createuser" className="UserIcon">
              Create New User
            </Link>
          </Button>
        </Col>
      </Row>
      <Table>
        <thead>
          <tr>
            <td>{user.Fullname}</td>
            <td>{user.Username}</td>
            <td>{user.Email}</td>
            <td>{user.PhoneNumber}</td>
            <th></th>
          </tr>
        </thead>
        {/* <tbody>{props.children}</tbody> */}
        <tbody>
          {props.isLoading ? (
            <tr>
              <td className="rowNotify">...Loading</td>
            </tr>
          ) : props.totalItems > 0 ? (
            props.children
          ) : (
            <tr>
              <td className="rowNotify"> No Users are found! </td>
            </tr>
          )}
        </tbody>
      </Table>
    </div>
  );
}

export default UserList;
