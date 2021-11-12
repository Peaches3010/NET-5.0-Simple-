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
const CreateCategories = () => {
  return (
    <div>
      <h5 className="right-title">Create New Category</h5>
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
export default CreateCategories;
