import axios from "axios";
import React from "react";
import {
  Button,
  Row,
  Form,
  Col,
  FormGroup,
  Label,
  Input,
  FormText,
} from "reactstrap";
const CreateProducts = () => {
  onImageChange = (event) => {
    this.setState({
      selectedFile: event.target.files[0],
    });
  };
  uploadImage = () => {};

  return (
    <div>
      <h5 className="right-title">Create New Products</h5>
      <form>
        <div className="form-group row">
          <label htmlFor="nameAssets" className="col-sm-2 col-form-label">
            Name
          </label>
          <div className="col-sm-10" className="resize">
            <input type="text" className="form-control" id="nameAssets" />
          </div>
        </div>
        <br></br>
        <div className="form-group row">
          <label htmlFor="categoryAssets" className="col-sm-2 col-form-label">
            Category
          </label>
          <div className="col-sm-10" className="resize">
            <select
              className="custom-select custom-select-lg mb-3"
              className="form-control"
            >
              <option value={0}></option>
              <option value={1}>Laptop</option>
              <option value={2}>Monitor</option>
            </select>
          </div>
        </div>
        <br></br>
        <div className="form-group row">
          <label
            htmlFor="specificationCategory"
            className="col-sm-2 col-form-label"
          >
            Description
          </label>
          <div className="col-sm-10" className="resize">
            <input
              type="text"
              className="form-control height"
              id="specificationCategory"
            />
          </div>
        </div>
        <br></br>
        <div className="form-group row">
          <label htmlFor="installedDate" className="col-sm-2 col-form-label">
            Installed Date
          </label>
          <div className="col-sm-10" className="resize">
            <input
              type="date"
              className="form-control "
              id="installedDate"
              name="installedDate"
            />
          </div>
        </div>
        <br></br>
        <div className="form-group row">
          <label
            htmlFor="specificationCategory"
            className="col-sm-2 col-form-label"
          >
            Price
          </label>
          <div className="col-sm-10" className="resize">
            <input
              type="text"
              className="form-control height"
              id="specificationCategory"
            />
          </div>
        </div>
        <br></br>
        <div className="form-group row">
          <label
            htmlFor="specificationCategory"
            className="col-sm-2 col-form-label"
          >
            Cost
          </label>
          <div className="col-sm-10" className="resize">
            <input
              type="text"
              className="form-control height"
              id="specificationCategory"
            />
          </div>
        </div>
        <br></br>
        <div className="form-group row">
          <label
            htmlFor="specificationCategory"
            className="col-sm-2 col-form-label"
          >
            Image
          </label>
          <div className="col-sm-10" className="resize">
            <img src={this.state.image} />
            <h1>Select Image</h1>
            <input type="file" name="myImage" onChange={this.onImageChange} />
            <button onClick={this.uploadImage}></button>
          </div>
        </div>
        <br></br>
        <button type="button" class="btn btn-outline-danger margin color">
          Save
        </button>
        <button type="button" class="btn btn-outline-danger color1">
          Cancel
        </button>
      </form>
    </div>
  );
};
export default CreateProducts;
