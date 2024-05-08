package dmacc.beans;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Table;

import org.springframework.beans.factory.annotation.Autowired;

@Entity
@Table(name="my_contacts")
public class Contact {
	@Id
	@GeneratedValue
	private long id;
	@Column(name="first_name")
	private String name;
	private String phone;
	private String relationship;
	@Autowired
	private Address address;
	
	/*
	 * @ManyToOne
	 * private ArrayList <Address> addresses;
	 * 
	 * @Column(name="timestamp")
	 * @CreationTimestamp
	 * private LocalDateTime timestamp;
	 */
	
	public Contact() {
		super();
	}
	
	public Contact(String name) {
		super();
		setName(name);
		this.relationship = "spouse";
	}
	
	public Contact(String name, String phone, String relationship) {
		super();
		setName(name);
		setPhone(phone);
		setRelationship(relationship);
	}
	
	public Contact(int id, String name, String phone, String relationship) {
		super();
		setId(id);
		setName(name);
		setPhone(phone);
		setRelationship(relationship);
	}

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getPhone() {
		return phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public String getRelationship() {
		return relationship;
	}

	public void setRelationship(String relationship) {
		this.relationship = relationship;
	}
	
	public Address getAddress() {
		return address;
	}
	
	public void setAddress(Address address) {
		this.address = address;
	}

	@Override
	public String toString() {
		return "Contact [id=" + id + ", name=" + name + ", phone=" + phone + ", relationship=" + relationship
				+ ", address=" + address + "]";
	}

	

	

}
