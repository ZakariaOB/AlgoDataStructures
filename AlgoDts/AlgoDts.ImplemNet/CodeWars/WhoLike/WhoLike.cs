namespace AlgoDts.ImplemNet.CodeWars.WhoLike
{
    public class WhoLike
    {
        public static string Likes(string[] name)
        {
            const string noOneLike = "no one likes this";
            const string likesThis = "likes this";
            const string likeThis = "like this";
            const string others = "others like this";
            switch (name.Length)
            {
                case 0:
                    return noOneLike;
                case 1:
                    return $"{name[0]} {likesThis}";
                case 2:
                    return $"{name[0]} and {name[1]} {likeThis}";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} {likeThis}";
                default:
                    return $"{name[0]}, {name[1]} and {name.Length - 2} {others}";
            }
        }
    }
}
