
export interface UserAuth {
    username:string, 
    password:string
}

export interface UserCreate {
    username: string;
    password: string;
    confirmPassword:string;
    role_id:  number;
}
