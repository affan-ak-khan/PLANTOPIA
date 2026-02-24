# Plant Store Management System

A full-featured **desktop store management application** built with **C# Windows Forms (.NET Framework 4.8)** and **SQL Server LocalDB**. The system supports two roles — **Admin** and **User** — with a modern dark-themed UI powered by Guna UI 2 and Bunifu UI libraries.

---

## 📽️ Demo

▶️ Watch the presentation: [https://youtu.be/8mMHC4KSjKs](https://youtu.be/8mMHC4KSjKs)

---

## ✨ Features

### 👤 User
- Register & Login with email/password
- View and browse available products with images
- Search products by name
- Add a Credit Card to the account
- Top up Wallet (min €1 – max €1000 per transaction)
- Buy products via **Card** (deducted from wallet) or **Manual** payment
- View full Order History with product, price, quantity, and payment method

### 🔑 Admin
- Admin Dashboard with live stats:
  - Total Users, Total Admins, Total Products, Store Budget
- Add new products with name, price, quantity, and image
- Delete products by ID
- List and search all registered users
- Delete user accounts (removes from all tables)
- Track store revenue (budget updates on every card purchase)

---

## 🖥️ Tech Stack

| Technology | Details |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.8 |
| UI | Windows Forms |
| UI Libraries | [Guna UI 2](https://gunaui.com/), Bunifu UI v1.52 |
| Database | SQL Server LocalDB (`.mdf`) |
| DB Access | ADO.NET (`SqlConnection`, `SqlDataAdapter`, `SqlCommand`) |
| IDE | Visual Studio 2019 / 2022 |

---

## 📁 Project Structure

```
Viva-Store-Management-System-master/
├── VivaStore/
│   ├── Program.cs              # Entry point → launches LogReg form
│   ├── LogReg.cs               # Login & Registration form
│   ├── AdminDash.cs            # Admin dashboard
│   ├── UserDash.cs             # User dashboard
│   ├── AProdControl.cs         # Admin product card (UserControl)
│   ├── AProfileControl.cs      # Admin user profile card (UserControl)
│   ├── UProdControl.cs         # User product card (UserControl)
│   ├── UOrdersControl.cs       # User order history card (UserControl)
│   ├── App.config              # Database connection string config
│   └── VivaStore.csproj        # Project file
├── VStoreDB.mdf                # SQL Server LocalDB database file
├── VStoreDB_log.ldf            # Database log file
└── VivaStore.sln               # Solution file
```

---

## 🗄️ Database Tables

| Table | Columns |
|---|---|
| `UserTbl` | FullName, Email, Address, Password, Role |
| `UDataTbl` | UserName, UserEmail, Wallet, TotalSpent, CCName, CCNum, CCExp, CCAdd |
| `ProductsTbl` | IDP, Product, Price, Quantity, Image |
| `OrdersTbl` | CustEmail, CustName, CustDeliver, CustProduct, CustPrice, CustQty, CustPayment, CustTotal |
| `BudgetTbl` | Budget |

---

## ⚙️ Installation & Setup

### Prerequisites

- **Windows** OS
- **Visual Studio 2019 or 2022** with `.NET desktop development` workload
- **SQL Server LocalDB** (included with Visual Studio)
- **Bunifu UI v1.52** DLL (see note below)
- **Guna UI 2** NuGet package (auto-restored)

---

### Step 1 — Clone the Repository

```bash
git clone https://github.com/affan-ak-khan/PLANTOPIA.git
cd PLANTOPIA/Viva-Store-Management-System-master
```

---

### Step 2 — Place the Bunifu DLL

The project requires `Bunifu_UI_v1.52.dll`. Place it at:

```
C:\Users\<YourUsername>\VS 2019 dodaci\Bunifu_UI_v1.52.dll
```

Or update the `HintPath` in `VivaStore/VivaStore.csproj`:

```xml
<HintPath>path\to\your\Bunifu_UI_v1.52.dll</HintPath>
```

---

### Step 3 — Fix the Database Connection String

Open `VivaStore/App.config` and update the `AttachDbFilename` path to match where the `.mdf` file is on **your machine**:

```xml
<connectionStrings>
  <add name="VCS"
       connectionString="Data Source=(LocalDB)\MSSQLLocalDB;
                         AttachDbFilename=C:\YOUR\PATH\TO\VStoreDB.mdf;
                         Integrated Security=True;Connect Timeout=30"
       providerName="System.Data.SqlClient"/>
</connectionStrings>
```

Replace `C:\YOUR\PATH\TO\` with the actual absolute path to `VStoreDB.mdf`.

---

### Step 4 — Restore NuGet Packages

Open the solution in Visual Studio, then:

```
Tools → NuGet Package Manager → Restore NuGet Packages
```

Or via CLI:
```bash
nuget restore VivaStore.sln
```

---

### Step 5 — Build & Run

1. Open `VivaStore.sln` in Visual Studio
2. Set build configuration to **Debug**
3. Press **F5** or click **Start**

The app starts with the **Login / Register** screen (`LogReg` form).

---

## 🔐 Default Admin Account

To create an admin account, register a normal user first, then manually update the `Role` field in `UserTbl` from `user` to `administrator` using SQL Server Management Studio (SSMS) or Visual Studio's database tools.

---

## ⚠️ Known Issues

- Connection string must be manually updated per machine (absolute path to `.mdf`)
- `Bunifu_UI_v1.52.dll` is a paid library and must be obtained separately
- SQL queries use string concatenation (no parameterized queries for most operations) — not recommended for production use

---

## 👨‍💻 Author

**Affan AK Khan**  
GitHub: [@affan-ak-khan](https://github.com/affan-ak-khan)  


---

## 📄 License

This project is for educational purposes.
