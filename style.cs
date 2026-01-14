@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;500;600;700&display=swap');

* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Poppins', sans-serif;
}

body {
  background: #f8f7f3;
}

/* Layout */
.dashboard {
  display: flex;
  min-height: 100vh;
}

/* Sidebar */
.sidebar {
  width: 260px;
  background: #fff;
  padding: 25px;
  border-right: 1px solid #eee;
  display: flex;
  flex-direction: column;
}

.brand {
  text-align: center;
  margin-bottom: 30px;
}

.brand .logo {
  font-size: 36px;
}

.brand span {
  font-size: 13px;
  color: #888;
}

.sidebar nav a {
  display: block;
  padding: 12px 15px;
  border-radius: 10px;
  margin-bottom: 10px;
  color: #444;
  cursor: pointer;
}

.sidebar nav a.active,
.sidebar nav a:hover {
  background: #ffcc00;
  color: #000;
}

.logout {
  margin-top: auto;
  padding: 12px;
  border: none;
  border-radius: 12px;
  background: #f2f2f2;
  cursor: pointer;
}

/* Main */
.main {
  flex: 1;
  padding: 30px;
}

/* Topbar */
.topbar {
  display: flex;
  justify-content: space-between;
  margin-bottom: 25px;
}

.topbar input {
  padding: 10px 15px;
  border-radius: 12px;
  border: none;
  background: #eee;
}

/* Header */
.header p {
  color: #777;
}

/* Stats */
.stats {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 20px;
  margin: 25px 0;
}

.stat-card {
  background: #fff;
  padding: 20px;
  border-radius: 16px;
}

.stat-card span {
  color: #777;
}

.up {
  color: green;
  font-size: 14px;
}

.new {
  color: orange;
  font-size: 14px;
}

/* Content */
.content {
  display: grid;
  grid-template-columns: 2fr 1fr;
  gap: 25px;
}

/* Product */
.product-card {
  background: #fff;
  border-radius: 20px;
  overflow: hidden;
}

.product-card img {
  width: 100%;
  height: 260px;
  object-fit: cover;
}

.product-info {
  padding: 20px;
}

.price {
  color: #ffb703;
  font-weight: 600;
}

.actions {
  margin-top: 15px;
}

.btn {
  padding: 10px 16px;
  border-radius: 10px;
  border: none;
  cursor: pointer;
  margin-right: 10px;
}

.primary {
  background: #ffcc00;
}

.outline {
  background: none;
  border: 1px solid #ffcc00;
}

/* Cards */
.card {
  background: #fff;
  border-radius: 16px;
  padding: 20px;
  margin-bottom: 20px;
}

.card-header {
  display: flex;
  justify-content: space-between;
  margin-bottom: 15px;
}

/* Team */
.team-item {
  display: flex;
  align-items: center;
  margin-bottom: 15px;
}

.team-item img {
  width: 42px;
  height: 42px;
  border-radius: 50%;
  margin-right: 10px;
}

.team-item span {
  font-size: 13px;
  color: #777;
}

/* Contact */
.contact a {
  display: block;
  margin-top: 10px;
  padding: 12px;
  border-radius: 12px;
  text-align: center;
  text-decoration: none;
}

.contact .ig {
  background: #ffe9f0;
}

.contact .wa {
  background: #25d366;
  color: #fff;
}

/* Flavor */
.flavors {
  margin-top: 30px;
}

.flavor-list {
  display: flex;
  gap: 15px;
  margin-top: 15px;
}

.flavor {
  background: #fff;
  padding: 14px 20px;
  border-radius: 14px;
  cursor: pointer;
}
