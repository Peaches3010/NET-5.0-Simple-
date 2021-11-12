import React from "react";
import Home from "../pages/Home";
import ManageUser from "../pages/ManageUser";
import ManageProduct from "../pages/ManageProduct";
import ManageCategory from "../pages/ManageCategory"
import CreateUser from "../pages/ManageUser/CreateUser";
import EditUser from "../pages/ManageUser/EditUser";
import CreateProducts from "../pages/ManageProduct/CreateProducts";
import EditProducts from "../pages/ManageProduct/EditProducts";
import CreateCategories from "../pages/ManageCategory/CreateCategories";
import EditCategories from "../pages/ManageCategory/EditCategories";


const routes = [
  {
    path: "/",
    exact: true,
    main: () => <Home />,
  },
  {
    path: "/manage-user",
    exact: false,
    main: () => <ManageUser />,
  },
  {
    path: "/manage-product",
    exact: false,
    main: () => <ManageProduct />,
  },
  {
    path: "/manage-category",
    exact: false,
    main: () => <ManageCategory />,
  },
  {
    path: "/createuser",
    exact: false,
    main: () => <CreateUser />,
  },
  {
    path: "/edituser",
    exact: false,
    main: () => <EditUser />,
  },
  {
    path: "/createproducts",
    exact: false,
    main: () => <CreateProducts />,
  },
  {
    path: "/editproducts",
    exact: false,
    main: () => <EditProducts />,
  },
  {
    path: "/createcategories",
    exact: false,
    main: () => <CreateCategories />,
  },
  {
    path: "/editcategories",
    exact: false,
    main: () => <EditCategories />,
  },


  {
    path: "",
    exact: false,
    // main: () => <NotFoundPage />
  },
];

export default routes;
