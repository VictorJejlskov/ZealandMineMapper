import PostUser from "./PostUser";

interface PostObject{
    postId: number
    thisUser: PostUser
    picture: string
    description: string
    postDate: string
}
export default PostObject;