﻿
namespace appRT
{
    class SConnection
    {
        public static readonly string SC = "Data Source=(localdb)\\MSSQLLocalDB;" +
                                          @"Initial Catalog=BDKRT;" +
                                          @"Integrated Security=True;" +
                                          @"Connect Timeout=30;" +
                                          @"Encrypt=False;" +
                                          @"TrustServerCertificate=False;" +
                                          @"ApplicationIntent=ReadWrite;" +
                                          @"MultiSubnetFailover=False";
        
    }
}
