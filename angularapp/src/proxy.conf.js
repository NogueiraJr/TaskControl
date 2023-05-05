const PROXY_CONFIG = [
  {
    context: [
      "/todolist",
    ],
    target: "https://localhost:4200",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
