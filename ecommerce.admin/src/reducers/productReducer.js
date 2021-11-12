import *as types from "../action/ManageProduct/ActionType";

const initialState = [];

function productReducer(state = initialState, action) {
    const { type, payload } = action;

    switch (type) {
        case types.CREATE_PRODUCT:
            return [...state, payload];

        case types.FETCH_PRODUCT:
            // console.log(action.payload.data);
            return payload.data;

        case types.UPDATE_PRODUCT:
            return state.map((product) => {
                if (product.id === payload.id) {
                    return {
                        ...product,
                        ...payload,
                    };
                } else {
                    return user;
                }
            });

        case types.DELETE_PRODUCT:
            return state.filter(({ id }) => id !== payload.id);

        default:
            return state;
    }
};

export default productReducer;