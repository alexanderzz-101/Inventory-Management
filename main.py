import mysql.connector # communicates 
from mysql.connector import Error
from dotenv import load_dotenv # loads variables from .env 
import os # reads environment variables from .env

load_dotenv()

def create_connection():
    try:
        connection = mysql.connector.connect(
            host = os.getenv("DB_HOST"),
            database = os.getenv("DB_NAME"),
            user = os.getenv("DB_USER"),
            password = os.getenv("DB_PASSWORD"),
        )
        if connection.is_connected():
            print ("Successfully connected to MySQL Database")
            return connection
    except Error as e:
        print(f"There is an error while connecting to MySQL: {e}")    
        return None