const PROXY_CONFIG = [
  {
    context: [
      "/TodoList",
    ],
    target: "https://localhost:7031",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
