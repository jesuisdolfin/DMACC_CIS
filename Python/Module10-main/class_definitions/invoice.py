class Invoice:

    def __init__(self, invoice_id, customer_id, last_name, first_name, phone_number, address):
        self.invoice_id = invoice_id
        self.customer_id = customer_id
        self.last_name = last_name
        self.first_name = first_name
        self.phone_number = phone_number
        self.address = address

        self.items_with_price = dict()

    def set_invoice_id(self, invoice_id):
        self.invoice_id = invoice_id

    def set_customer_id(self, customer_id):
        self.customer_id = customer_id

    def set_last_name(self, last_name):
        self.last_name = last_name

    def set_first_name(self, first_name):
        self.first_name = first_name

    def set_phone_number(self, phone_number):
        self.phone_number = phone_number

    def set_address(self, address):
        self.address = address

    def set_items_with_price(self, items_with_price):
        self.items_with_price = items_with_price

    def add_item(self, item, price):
        self.items_with_price.update({item: price})

    def create_invoice(self):
        total = 0
        for item, price in self.items_with_price.items():
            print(item, '..... $', price)
            total += price
        tax = price * 0.06
        f_total = "{:.2f}".format(total)
        f_tax = "{:.2f}".format(tax)
        print('Tax ..... $', f_tax)
        print('Total ..... $', float(f_tax) + float(f_total))

    def __str__(self) -> str:
        return super().__str__()

    def __repr__(self) -> str:
        return super().__repr__()


if __name__ == '__main__':
    invoice = Invoice(1, 123, 'Mouse', 'Minnie', '555-867-5309', '1313 Disneyland Dr, Anaheim, CA 92802')
    invoice.add_item('iPad', 799.99)
    invoice.add_item('Surface', 999.99)
    invoice.create_invoice()
