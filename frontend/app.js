const { createApp } = Vue;

createApp({
  data() {
    return { orders: [] };
  },
  mounted() {
    fetch('/api/orders')
      .then(res => res.json())
      .then(data => {
        this.orders = data;
      });
  }
}).mount('#app');
