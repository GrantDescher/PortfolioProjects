IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231213192529_InitialSetup'
)
BEGIN
    CREATE TABLE [Categories] (
        [CategoryId] int NOT NULL IDENTITY,
        [CategoryName] nvarchar(max) NOT NULL,
        [CategoryDescription] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryId])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231213192529_InitialSetup'
)
BEGIN
    CREATE TABLE [Products] (
        [ProductId] int NOT NULL IDENTITY,
        [ProductName] nvarchar(max) NOT NULL,
        [ProductDescription] nvarchar(max) NOT NULL,
        [ProductPrice] float NOT NULL,
        [ProductImageURL] nvarchar(max) NOT NULL,
        [ProductImageThumbnailURL] nvarchar(max) NOT NULL,
        [IsProductOnSale] bit NOT NULL,
        [IsProductInStock] bit NOT NULL,
        [CategoryID] int NOT NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([ProductId]),
        CONSTRAINT [FK_Products_Categories_CategoryID] FOREIGN KEY ([CategoryID]) REFERENCES [Categories] ([CategoryId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231213192529_InitialSetup'
)
BEGIN
    CREATE TABLE [ShoppingCartItems] (
        [ShoppingCartItemId] int NOT NULL IDENTITY,
        [ShoppingCartId] nvarchar(max) NULL,
        [ProductId] int NULL,
        [Amount] int NOT NULL,
        CONSTRAINT [PK_ShoppingCartItems] PRIMARY KEY ([ShoppingCartItemId]),
        CONSTRAINT [FK_ShoppingCartItems_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231213192529_InitialSetup'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryDescription', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    EXEC(N'INSERT INTO [Categories] ([CategoryId], [CategoryDescription], [CategoryName])
    VALUES (1, N'''', N''Motherboard''),
    (2, N'''', N''Processor''),
    (3, N'''', N''Memory''),
    (4, N'''', N''Video Graphics Card''),
    (5, N'''', N''Case''),
    (6, N'''', N''Power Supply''),
    (7, N'''', N''Storage''),
    (8, N'''', N''Accessory'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryDescription', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231213192529_InitialSetup'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'CategoryID', N'IsProductInStock', N'IsProductOnSale', N'ProductDescription', N'ProductImageThumbnailURL', N'ProductImageURL', N'ProductName', N'ProductPrice') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    EXEC(N'INSERT INTO [Products] ([ProductId], [CategoryID], [IsProductInStock], [IsProductOnSale], [ProductDescription], [ProductImageThumbnailURL], [ProductImageURL], [ProductName], [ProductPrice])
    VALUES (1, 1, CAST(1 AS bit), CAST(1 AS bit), N''Buffed and ready with more power, robust cooling, and flexible I/O to scale up your rig at will. The ROG Maximus Z790 Hero puts it all at your disposal together with an arsenal of features and utilities to truly express the PC builder, overclocker, and gaming hero in you.'', N''/images/product01.jpg'', N''/images/product01.jpg'', N''ASUS ROG Maximus Z790 Hero'', 609.99000000000001E0),
    (2, 1, CAST(1 AS bit), CAST(0 AS bit), N''Featurign Core Boost Technology, 6 layer PCB, and the highest quality power delivery components, the MSI MAG B550 Tomahawk gives you unmatched performance at an unbeatable price.'', N''/images/product02.jpg'', N''/images/product02.jpg'', N''MSI MAG B550 Tomahawk'', 169.99000000000001E0),
    (3, 1, CAST(1 AS bit), CAST(0 AS bit), N''ROG Strix Z690-E Gaming Wi-Fi puts 12th Gen Intel® Core™ processors at center stage, with beefed-up power delivery, cooling, cutting-edge connectivity options, and a range of accoutrements that effortlessly propel builds to maximum performance. This series flagship is your ticket to next-level gaming.'', N''/images/product03.jpg'', N''/images/product03.jpg'', N''ASUS ROG Strix Z690-E'', 279.99000000000001E0),
    (4, 2, CAST(1 AS bit), CAST(0 AS bit), N''Get the competitive edge with 12 cores, 24 threads, boost clocks of up to 4.8GHz2 and 70MB of cache.'', N''/images/product04.jpg'', N''/images/product04.jpg'', N''AMD Ryzen 9 5900X'', 549.99000000000001E0),
    (5, 2, CAST(1 AS bit), CAST(0 AS bit), N''Blazing-fast clock speeds and a revolutionary core architecture allow you to seamlessly chat, stream and record without sacrificing gameplay.'', N''/images/product05.jpg'', N''/images/product05.jpg'', N''Intel Core i7-12700K'', 449.99000000000001E0),
    (6, 2, CAST(1 AS bit), CAST(0 AS bit), N''With the highest clock speeds and a groundbreaking new architecture, you’ll be able to push your gameplay to new heights while secondary apps run seamlessly in the background.'', N''/images/product06.jpg'', N''/images/product06.jpg'', N''Intel Core i9-12700K'', 649.99000000000001E0),
    (7, 3, CAST(1 AS bit), CAST(0 AS bit), N''As the latest addition to the classic RipJaws family, RipJaws V series DDR4 memory is designed for sleek aesthetics and performance. Ripjaws V is the ideal choice for building a new performance system or for DRAM memory upgrade.'', N''/images/product07.jpg'', N''/images/product07.jpg'', N''G.SKILL Ripjaws V Series 32 GB'', 64.989999999999995E0),
    (8, 3, CAST(1 AS bit), CAST(0 AS bit), N''Speed up loading times, boost system responsiveness, and improve your computers ability to handle greater workloads with Nemix Ram''''s 32GB kit.'', N''/images/product08.jpg'', N''/images/product08.jpg'', N''Nemix Ram 32GB Kit'', 97.989999999999995E0),
    (9, 3, CAST(1 AS bit), CAST(0 AS bit), N''VENGEANCE LPX memory is designed for high-performance overclocking. Whether you''''re breaking your own records or you''''re simply building a dream gaming rig, you can count on CORSAIR memory.'', N''/images/product09.jpg'', N''/images/product09.jpg'', N''Corsair Vengeance LPX 16GB'', 51.990000000000002E0),
    (10, 4, CAST(1 AS bit), CAST(0 AS bit), N''Granting peak performance at an affordable price, the best selling MSI Ventus GeForce RTX 3060 is a must have for newcomers and enthusiasts alike.'', N''/images/product10.jpg'', N''/images/product10.jpg'', N''MSI Ventus GeForce RTX 3060'', 289.99000000000001E0),
    (11, 4, CAST(1 AS bit), CAST(0 AS bit), N''Looking to power up your rig? Look no further than the GIGABYTE Gaming OC RTX 3070. Offering NVIDIA multiprocessors, Windforce cooling systems, and a 1815 MHz core clock, this card offers unparalleled performance.'', N''/images/product11.jpg'', N''/images/product11.jpg'', N''GIGABYTE Gaming OC GeForce 3070'', 569.99000000000001E0),
    (12, 4, CAST(1 AS bit), CAST(0 AS bit), N''Get equipped to play the newest games at the highest settings with 12GB of GDDR6 memory and 40 enhanced compute units delivering 1440p gaming at ultra settings with smooth framerates and maximum visual settings.'', N''/images/product12.jpg'', N''/images/product12.jpg'', N''ASRock Radeon RX 6700 XT'', 329.99000000000001E0)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'CategoryID', N'IsProductInStock', N'IsProductOnSale', N'ProductDescription', N'ProductImageThumbnailURL', N'ProductImageURL', N'ProductName', N'ProductPrice') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231213192529_InitialSetup'
)
BEGIN
    CREATE INDEX [IX_Products_CategoryID] ON [Products] ([CategoryID]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231213192529_InitialSetup'
)
BEGIN
    CREATE INDEX [IX_ShoppingCartItems_ProductId] ON [ShoppingCartItems] ([ProductId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231213192529_InitialSetup'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231213192529_InitialSetup', N'8.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231215203731_ProductsAdded'
)
BEGIN
    EXEC(N'DELETE FROM [Categories]
    WHERE [CategoryId] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231215203731_ProductsAdded'
)
BEGIN
    EXEC(N'DELETE FROM [Categories]
    WHERE [CategoryId] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231215203731_ProductsAdded'
)
BEGIN
    EXEC(N'UPDATE [Categories] SET [CategoryName] = N''Storage''
    WHERE [CategoryId] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231215203731_ProductsAdded'
)
BEGIN
    EXEC(N'UPDATE [Categories] SET [CategoryName] = N''Accessory''
    WHERE [CategoryId] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231215203731_ProductsAdded'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'CategoryID', N'IsProductInStock', N'IsProductOnSale', N'ProductDescription', N'ProductImageThumbnailURL', N'ProductImageURL', N'ProductName', N'ProductPrice') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    EXEC(N'INSERT INTO [Products] ([ProductId], [CategoryID], [IsProductInStock], [IsProductOnSale], [ProductDescription], [ProductImageThumbnailURL], [ProductImageURL], [ProductName], [ProductPrice])
    VALUES (13, 5, CAST(1 AS bit), CAST(1 AS bit), N''Purpose built for multi-user NAS environments, Seagate IronWolf drives are perfect for teams needing to store more and work faster.'', N''/images/product13.jpg'', N''/images/product13.jpg'', N''Seagate IronWolf 12TB NAS Harddrive Internal HDD'', 359.99000000000001E0),
    (14, 5, CAST(1 AS bit), CAST(0 AS bit), N''Perfect for reliable, everyday computing with Western Digital quality and reliability.'', N''/images/product14.jpg'', N''/images/product14.jpg'', N''WD Blue 500GB Desktop Hard Disk Drive'', 59.990000000000002E0),
    (15, 5, CAST(1 AS bit), CAST(0 AS bit), N''Cost effective storage for laptop or desktop computers. Store all your games, music, movies and more with up to 8TB of storage.'', N''/images/product15.jpg'', N''/images/product15.jpg'', N''Seagate BarraCude 8TB SATA Internal Hard Drive'', 189.99000000000001E0),
    (16, 5, CAST(1 AS bit), CAST(1 AS bit), N''Compatible with PC, desktop, laptop, Xbox One, and PS4. Plug and play - no software to install and ready to use.'', N''/images/product16.jpg'', N''/images/product16.jpg'', N''UnionSine 1TB Ultra Slim Portable External Hard Drive'', 55.990000000000002E0),
    (17, 5, CAST(1 AS bit), CAST(0 AS bit), N''With massive capacity and innovative technology advancements, this Exos X18 enterprise hard drive is engineered to address the needs of the hyperscale storage market.'', N''/images/product17.jpg'', N''/images/product17.jpg'', N''Seagate 18TB Exos Enterprise Hard Drive HDD'', 399.99000000000001E0),
    (18, 5, CAST(1 AS bit), CAST(0 AS bit), N''Compatible with all of your devices, the T7 Shield features read/write speeds of up to 1,000 MB/s and a durable design to resist wear and damage.'', N''/images/product18.jpg'', N''/images/product18.jpg'', N''Samsung T7 Shield 4TB External Solid State Drive'', 249.99000000000001E0),
    (19, 5, CAST(1 AS bit), CAST(1 AS bit), N''With excellent performance including read speeds of up to $5,000MB/s, this drive enhances the speed and performance of your entire system.'', N''/images/product19.jpg'', N''/images/product19.jpg'', N''T-Force Cardea 1TB NVME Internal Solid State Drive'', 74.989999999999995E0),
    (20, 5, CAST(1 AS bit), CAST(0 AS bit), N''With blistering speeds of up to 12,000MB/s, experience performance like you never have before. Perfect for the ultimate gaming and creative computer.'', N''/images/product20.jpg'', N''/images/product20.jpg'', N''Crucial T700 2TB NVME Internal Solid State Drive'', 295.99000000000001E0),
    (21, 5, CAST(1 AS bit), CAST(0 AS bit), N''KingSpec NVME SSD is the ideal data storage solution for your desktop or laptop, drastically improving performace and efficiency.'', N''/images/product21.jpg'', N''/images/product21.jpg'', N''KingSpec 1TB NVME Internal Solid State Drive'', 121.98999999999999E0),
    (22, 6, CAST(1 AS bit), CAST(0 AS bit), N''Keep your system looking and running cool with the premier RBG lighting fans on the market.'', N''/images/product22.jpg'', N''/images/product22.jpg'', N''Corsair iCUE RGB Elite Triple Fan Kit Black'', 51.990000000000002E0),
    (23, 6, CAST(1 AS bit), CAST(1 AS bit), N''Keep your system looking and running cool with the premier RBG lighting fans on the market.'', N''/images/product23.jpg'', N''/images/product23.jpg'', N''Corsair iCUE RGB Elite Triple Fan Kit White'', 79.989999999999995E0),
    (24, 6, CAST(1 AS bit), CAST(0 AS bit), N''Premium quiet fan with advanced flow channels and acoustic optimisation for quiet cooling.'', N''/images/product24.jpg'', N''/images/product24.jpg'', N''Noctua Premium Quiet Fan - Brown'', 23.949999999999999E0),
    (25, 6, CAST(1 AS bit), CAST(1 AS bit), N''The final component of your gaming system. A good monitor elevates the performance of all of your PC components. GIGABYTE gaming monitors offer the best boost in the business.'', N''/images/product25.jpg'', N''/images/product25.jpg'', N''GIGABYTE G27Q 27 inch 144Hz 1440p Gaming Monitor'', 249.99000000000001E0),
    (26, 6, CAST(1 AS bit), CAST(0 AS bit), N''32 Inch display with ultrafast 175Hz refresh rate designed for the best gameplay. G-Sync compatibility offers seamless, tear-free experiences by default.'', N''/images/product26.jpg'', N''/images/product26.jpg'', N''ASUS 32 inch 1440p G-Sync Gaming Monitor'', 529.99000000000001E0),
    (27, 6, CAST(1 AS bit), CAST(0 AS bit), N''Ultra HD 3840 x 2160 Resultion and a 178 degree wide viewing angle offer unparalleled viewing experience.'', N''/images/product27.jpg'', N''/images/product27.jpg'', N''Z-EDGE U27P4K 27 inch IPS 4K Monitor'', 249.99000000000001E0),
    (28, 6, CAST(1 AS bit), CAST(1 AS bit), N''With rapid response and a sleek, stylish design, the MK710 is perfect for home desktops. Features up to three-year battery life.'', N''/images/product28.jpg'', N''/images/product28.jpg'', N''Logitech MK710 Wireless Keyboard and Mouse Combo'', 79.989999999999995E0),
    (29, 6, CAST(1 AS bit), CAST(0 AS bit), N''Made with recycled plastic, Pebble 2''''s minimalist, slim design makes for an iconic and portable accessory. Pairs with up to three devices via bluetooth.'', N''/images/product29.jpg'', N''/images/product29.jpg'', N''Logitech Pebble 2 Combo Wireless Keyboard and Mouse'', 59.990000000000002E0),
    (30, 6, CAST(1 AS bit), CAST(1 AS bit), N''Experience the feel of a mechanical keyboard with the responsiveness of a membrane keyboard. Features accurate feedback, reduced noise, and enhanced comfort.'', N''/images/product30.jpg'', N''/images/product30.jpg'', N''Rosewill NEON K42 Wired Mechanical Gaming Keyboard'', 49.990000000000002E0)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'CategoryID', N'IsProductInStock', N'IsProductOnSale', N'ProductDescription', N'ProductImageThumbnailURL', N'ProductImageURL', N'ProductName', N'ProductPrice') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231215203731_ProductsAdded'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231215203731_ProductsAdded', N'8.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231218221832_CompleteProducts'
)
BEGIN
    CREATE TABLE [Orders] (
        [OrderId] int NOT NULL IDENTITY,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [Address] nvarchar(max) NOT NULL,
        [City] nvarchar(max) NOT NULL,
        [State] nvarchar(2) NOT NULL,
        [ZipCode] nvarchar(5) NOT NULL,
        [PhoneNumber] nvarchar(max) NOT NULL,
        [OrderTotal] float NULL,
        [OrderPlaced] datetime2 NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderId])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231218221832_CompleteProducts'
)
BEGIN
    CREATE TABLE [OrderDetails] (
        [OrderDetailId] int NOT NULL IDENTITY,
        [OrderId] int NOT NULL,
        [ProductId] int NOT NULL,
        [Amount] int NOT NULL,
        [Price] float NOT NULL,
        CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([OrderDetailId]),
        CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([OrderId]) ON DELETE CASCADE,
        CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231218221832_CompleteProducts'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'CategoryID', N'IsProductInStock', N'IsProductOnSale', N'ProductDescription', N'ProductImageThumbnailURL', N'ProductImageURL', N'ProductName', N'ProductPrice') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    EXEC(N'INSERT INTO [Products] ([ProductId], [CategoryID], [IsProductInStock], [IsProductOnSale], [ProductDescription], [ProductImageThumbnailURL], [ProductImageURL], [ProductName], [ProductPrice])
    VALUES (31, 1, CAST(1 AS bit), CAST(0 AS bit), N''With the fast-moving technology changes, GIGABYTE always follows the latest trends and provides customers with advanced features and latest technologies. GIGABYTE motherboards are equipped with upgraded power solution, latest storage standards and outstanding connectivity to enable optimized performance for gaming.'', N''/images/product31.jpg'', N''/images/product31.jpg'', N''GIGABYTE Intel Z790 MOtherboard'', 249.99000000000001E0),
    (32, 1, CAST(1 AS bit), CAST(0 AS bit), N''AMD B650 Motherboard with support for AMD Ryzen 7000 Series Processors. '', N''/images/product32.jpg'', N''/images/product32.jpg'', N''ASRock B650 LiveMixer ATX Motherboard'', 229.99000000000001E0),
    (33, 1, CAST(1 AS bit), CAST(0 AS bit), N''With built in gaming WiFi and support for AMD Ryzen 7000 processors, the ASUS ROG STRIX B650-A Motherboard gives you all you need to up your game.'', N''/images/product33.jpg'', N''/images/product33.jpg'', N''ASUS ROG STRIX B650-A Motherboard'', 279.99000000000001E0),
    (34, 1, CAST(1 AS bit), CAST(0 AS bit), N''With the fast-moving technology changes, GIGABYTE always follows the latest trends and provides customers with advanced features and latest technologies. GIGABYTE motherboards are equipped with upgraded power solution, latest storage standards and outstanding connectivity to enable optimized performance for gaming.'', N''/images/product34.jpg'', N''/images/product34.jpg'', N''GIGABYTE B550 Aorus Elite Motherboard'', 189.99000000000001E0),
    (35, 1, CAST(1 AS bit), CAST(0 AS bit), N''AMD B650 Motherboard that supports AMD Ryzen 7000 Series Processors. Comes with lightning fast WiFi so you never have to worry about slowing down.'', N''/images/product35.jpg'', N''/images/product35.jpg'', N''MSI MPG B650 Edge Wifi Motherboard'', 259.99000000000001E0),
    (36, 2, CAST(1 AS bit), CAST(0 AS bit), N''The world''''s most advanced PC Processor. Take on any game with the pure speed of AMD Ryzen™ 5 7600X desktop processor.'', N''/images/product36.jpg'', N''/images/product36.jpg'', N''AMD Ryzen 5 7600X'', 249.99000000000001E0),
    (37, 2, CAST(1 AS bit), CAST(0 AS bit), N''Get the processor that is beautifully balanced for serious PC enthusiasts with “Zen 3” architecture1. With 8 cores, 16 threads, boost clocks of up to 4.6GHz2 and 36MB of total cache, the AMD Ryzen™ 7 5700X gives you the competitive edge.'', N''/images/product37.jpg'', N''/images/product37.jpg'', N''AMD Ryzen 7 5700X'', 178.99000000000001E0),
    (38, 2, CAST(1 AS bit), CAST(0 AS bit), N''Compete with confidence or get immersed in new worlds with a revolutionary processor architecture that focuses on what matters most – gaming.'', N''/images/product38.jpg'', N''/images/product38.jpg'', N''Intel Core i5 12600KF'', 217.99000000000001E0),
    (39, 2, CAST(1 AS bit), CAST(0 AS bit), N''Experience the speed of AMD Ryzen™ 7 7700X desktop processor. Build a rig with the winning performance you need to dominate the games you love.'', N''/images/product39.jpg'', N''/images/product39.jpg'', N''AMD Ryzen 7 7700X'', 399.99000000000001E0),
    (40, 2, CAST(1 AS bit), CAST(0 AS bit), N''Be unstoppable with the unprecedented speed of the AMD Ryzen™ 5000 G-Series desktop processors, whether you’re playing the latest games, designing the next skyscraper, or crunching scientific data. With AMD Ryzen™ desktop processors, you’re in the lead.'', N''/images/product40.jpg'', N''/images/product40.jpg'', N''AMD Ryzen 5 5600G'', 259.99000000000001E0),
    (41, 2, CAST(1 AS bit), CAST(0 AS bit), N''Featuring 6 cores (12 threads), 4.40 GHz Max Turbo frequency, and based on Intel''''s new micro architecture, the Core i5-12400 is a stellar gaming and multi-tasking processor with best-in-class price-performance ratio.'', N''/images/product41.jpg'', N''/images/product41.jpg'', N''Intel Core i5 12400'', 161.99000000000001E0),
    (42, 3, CAST(1 AS bit), CAST(0 AS bit), N''Get plenty of memory that will seamlessly integrate with your Intel or AMD-based SODIMM-compaible system.'', N''/images/product42.jpg'', N''/images/product42.jpg'', N''Mushkin Enhanced Redline 96GB RAM'', 269.99000000000001E0),
    (43, 3, CAST(1 AS bit), CAST(0 AS bit), N''Modeled after a stealth aircraft, the T-FORCE DELTA RGB DDR5 delivers a refreshing visual experience and continues to offer the 120° ultra-wide lighting and clean geometric silhouette found in the DELTA RGB DDR4.'', N''/images/product43.jpg'', N''/images/product43.jpg'', N''Team T-Force Delta RGB 32GB RAM'', 104.98999999999999E0),
    (44, 3, CAST(1 AS bit), CAST(0 AS bit), N''For the T-FORCE VULCAN DDR5, TEAMGROUP has adopted a gorgeous streamlines design with multi-angular to overall outline for visual aesthetics and showcase VULCAN DDR5''''s unique features, delivering a sleek OC gaming memory that packs a powerful performance.'', N''/images/product44.jpg'', N''/images/product44.jpg'', N''Team T-Force Vulcan 32GB RAM'', 94.989999999999995E0),
    (45, 3, CAST(1 AS bit), CAST(0 AS bit), N''SPECTRIX D35G''''s composed and understated triangular outline is specifically designed for gamers with unique personalities.'', N''/images/product45.jpg'', N''/images/product45.jpg'', N''XPG Spectra RBG 16GB RAM'', 47.990000000000002E0),
    (46, 4, CAST(1 AS bit), CAST(0 AS bit), N''The ZOTAC GAMING GeForce RTX 4070 Twin Edge is a compact and powerful graphics card, featuring the NVIDIA Ada Lovelace architecture and an aerodynamic-inspired design.'', N''/images/product46.jpg'', N''/images/product46.jpg'', N''ZOTAC Gaming GeForce RTX 4070 Twin Edge'', 549.99000000000001E0),
    (47, 4, CAST(1 AS bit), CAST(0 AS bit), N''With high speeds and a sleek design that will elevate any build, you can''''t want for more than what the PELADN Radeon 5500XT video card can offer you.'', N''/images/product47.jpg'', N''/images/product47.jpg'', N''PELADN Radeon 5500XT 8GB Video Card'', 199.99000000000001E0),
    (48, 4, CAST(1 AS bit), CAST(0 AS bit), N''Two fans that provide strong cooling performance and make your gaming rig stay cool. It’s optimized for delivering excellent gaming experience with stylish and streamlined design.'', N''/images/product48.jpg'', N''/images/product48.jpg'', N''ASRock Challenger Radeon RX 7700XT 12GB Video Card'', 449.99000000000001E0),
    (49, 4, CAST(1 AS bit), CAST(0 AS bit), N''Experience unparalleled performance with the ASUS TUF Gaming GeForce RTX 3070 V2 video graphics card. With a boost clock of 1845 MHz, there is not equal in performance.'', N''/images/product49.jpg'', N''/images/product49.jpg'', N''ASUS TUF Gaming GeForce RTX 3070 V2'', 629.99000000000001E0),
    (50, 4, CAST(1 AS bit), CAST(0 AS bit), N''ASUS Dual GeForce RTX™ 3050 OC Edition 8 GB GDDR6 with two powerful Axial-tech fans and a 2-slot design for broad compatibility.'', N''/images/product50.jpg'', N''/images/product50.jpg'', N''ASUS Dual GeForce RTX 3050'', 259.99000000000001E0)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'CategoryID', N'IsProductInStock', N'IsProductOnSale', N'ProductDescription', N'ProductImageThumbnailURL', N'ProductImageURL', N'ProductName', N'ProductPrice') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231218221832_CompleteProducts'
)
BEGIN
    CREATE INDEX [IX_OrderDetails_OrderId] ON [OrderDetails] ([OrderId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231218221832_CompleteProducts'
)
BEGIN
    CREATE INDEX [IX_OrderDetails_ProductId] ON [OrderDetails] ([ProductId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231218221832_CompleteProducts'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231218221832_CompleteProducts', N'8.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20231219002556_IdentityMigration'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231219002556_IdentityMigration', N'8.0.0');
END;
GO

COMMIT;
GO

