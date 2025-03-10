namespace enumFilePermission
{
    [Flags]
    enum FilePermission
    {
        Read = 1, Write = 2, Execute = 4
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FilePermission userpermission = FilePermission.Read | FilePermission.Write;
            Console.WriteLine($"user permissions are:{userpermission}");

            Checkpermission(userpermission,FilePermission.Read);
            Checkpermission(userpermission, FilePermission.Write);
            Checkpermission(userpermission,FilePermission.Execute);

        }
        static void Checkpermission(FilePermission userpermission,FilePermission checkpermission)
        {
            if((userpermission & checkpermission) == checkpermission)
            {
                Console.WriteLine($"user has permission to {checkpermission}");
            }
            else
            {
                Console.WriteLine($"user has no permission to {checkpermission}");
            }
        }
    }
}
