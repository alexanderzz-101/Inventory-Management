$(document).ready(function () {
    $('#barcode-input').on('input', function () {
        const barcode = $(this).val().trim();

        // Simulated lookup — replace with actual API call
        const productData = {
            '123456': { name: 'Coca-Cola 500ml', price: 25 },
            '789101': { name: 'Lucky Me Pancit Canton', price: 15 },
            '111213': { name: 'Bear Brand Powdered Milk', price: 10 }
        };

        if (productData[barcode]) {
            const product = productData[barcode];
            $('#product-info').html(`
        <h3>Product: ${product.name}</h3>
        <p>Price: ₱${product.price}</p>
      `);
        } else {
            $('#product-info').html(`<p>🔍 No product found for this barcode.</p>`);
        }
    });
});
