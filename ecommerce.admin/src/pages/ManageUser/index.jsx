import React, { useEffect, useState } from "react";
import * as action from "../../action/ManageUser/ActionType";
import { useDispatch, useSelector } from "react-redux";
import apiCaller from "../../apis/CallerApi";
import UserList from "../../components/User/UserList";
import UserItem from "../../components/User/UserItem";
function ManageUser() {
  const users = useSelector((state) => state.users);
  const dispatch = useDispatch();
  const [pageNumber, setPageNumber] = useState(1);
  const [paging, setPaging] = useState({
    name: "",
    type: "",
    page: 1,
    limit: 19,
    propertyName: "StaffCode",
    desc: false,
  });
  useEffect(() => {
    async function fetchUsers() {
      const res = await apiCaller("users", "GET", null);
      dispatch({ type: action.FETCH_USERS, payload: res });
    }
    fetchUsers();
  }, [paging]);
  console.log(users);

  const showUsers = () => {
    let result = null;
    if (users.length > 0) {
      result = users.map((user, index) => {
        return <UserItem key={index} user={user} index={index} />;
      });
    }
    return result;
  };
  return (
    <UserList
      totalPages={users.totalPages}
      totalItems={users.totalItems}
      pageNumber={pageNumber}
      setPageNumber={setPageNumber}
      setPaging={setPaging}
      paging={paging}
    >
      {showUsers()}
    </UserList>
  );
}

export default ManageUser;
