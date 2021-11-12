import React from "react";
import { Table } from "reactstrap";
import { IoMdCreate } from "@react-icons/all-files/io/IoMdCreate";
import { IoIosCloseCircleOutline } from "@react-icons/all-files/io/IoIosCloseCircleOutline";
import { AiOutlineSearch } from "@react-icons/all-files/ai/AiOutlineSearch";
import { AiFillFilter } from "@react-icons/all-files/ai/AiFillFilter";
import { Link } from "react-router-dom";
import {
  Col,
  Row,
  Button,
  InputGroupText,
  InputGroupAddon,
  Input,
  InputGroup,
} from "reactstrap";

function ManageCategory() {
  return (
    <div>
      <h5 className="right-title">Category List</h5>
      <Row from>
        <Col md={3}>
          <InputGroup>
            <select
              className="custom-select custom-select-lg mb-3"
              className="form-control"
            >
              <option selected>Category</option>
              <option value={0}></option>
              <option value={1}>Available</option>
              <option value={2}>Not Available</option>
            </select>

            <InputGroupAddon addonType="append">
              <InputGroupText className="right__icon">
                <AiFillFilter />
              </InputGroupText>
            </InputGroupAddon>
          </InputGroup>
        </Col>
        <Col md={6}>
          <InputGroup>
            <Input placeholder="Search" />
            <InputGroupAddon addonType="append">
              <InputGroupText className="right__icon">
                <AiOutlineSearch />
              </InputGroupText>
            </InputGroupAddon>
          </InputGroup>
        </Col>
        <Col md={3} className="text-right">
          <Button color="danger">
            <Link to="/createcategories" className="UserIcon">
              Create New Category
            </Link>
          </Button>
        </Col>
      </Row>
      <Table>
        <thead>
          <tr>
            <th>Category Name</th>
            <th>Assigned Date</th>
            <th>Description</th>
            <th>Creator</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <th>name</th>
            <td>Otto</td>
            <td>@mdo</td>
            <td>@mdo</td>
            <td>
              <span className="icon-nash icon-nash--black">
                <Link to="/editcategories">
                  <IoMdCreate />
                </Link>
              </span>
              <span className="icon-nash icon-nash--red">
                <IoIosCloseCircleOutline />
              </span>
            </td>
          </tr>
        </tbody>
      </Table>
    </div>
  );
}

export default ManageCategory;
