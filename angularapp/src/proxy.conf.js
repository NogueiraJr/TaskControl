const PROXY_CONFIG = [
  {
    context: [
      "/todolist",
    ],
    target: "https://localhost:7031",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
