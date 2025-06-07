from flask import Blueprint, request, jsonify
from mysql.connector import Error
from main import get_connection

product_bp = Blueprint('product_bp', __name__)

@product_bp.route('/api/product/add', methods = ['POST'])
def add_product():
    data = request.get.json()
    barcode = data.get('barcode')
    name = data.get('name')
    price = data.get('price')
    category = data.get('category')

    try:
        db = get_connection()
        cursor = db.cursor(dictionary=True)
        query = "INSERT INTO products (barcode, name, price, category) VALUES (%s, %s, %s, %s)"
        cursor.execute(query, (barcode, name, price, category))
        db.commit()
        cursor.close()
        db.close()
        return jsonify({"message" : "Product has been added successfully!"}), 201
    except Error as e:
        return jsonify({"error" : str(e)}), 500
