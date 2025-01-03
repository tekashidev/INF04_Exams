import { useState } from 'react';

function FilmForm() {
  const [formData, setFormData] = useState({
    title: '',
    category: '',
  });

  const categories = [
    { value: '', label: 'Wybierz...' },
    { value: 'Komedia', label: 'Komedia' },
    { value: 'Obyczajowy', label: 'Obyczajowy' },
    { value: 'Sensacyjny', label: 'Sensacyjny' },
    { value: 'Horror', label: 'Horror' },
  ];

  const handleInputChange = (event) => {
    const { name, value } = event.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    console.log(`tytul: ${formData.title}; rodzaj: ${formData.category}`);
  };

  return (
    <form onSubmit={handleSubmit} className="mt-4">
      <div className="form-group">
        <label htmlFor="title">Tytuł filmu</label>
        <input
          type="text"
          className="form-control"
          id="title"
          name="title"
          value={formData.title}
          onChange={handleInputChange}
          required
        />
      </div>
      <div className="form-group mt-3">
        <label htmlFor="category">Rodzaj</label>
        <select
          className="form-control"
          id="category"
          name="category"
          value={formData.category}
          onChange={handleInputChange}
          required
        >
          {categories.map((cat) => (
            <option key={cat.value} value={cat.value}>
              {cat.label}
            </option>
          ))}
        </select>
      </div>
      <button type="submit" className="btn btn-primary mt-3">
        Dodaj
      </button>
    </form>
  );
}

export default FilmForm;
