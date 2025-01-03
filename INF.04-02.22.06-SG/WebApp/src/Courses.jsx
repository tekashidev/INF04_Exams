import { useState } from 'react';

function Courses() {
  const [courses] = useState([
    'Programowanie w C#',
    'Angular dla początkujących',
    'Kurs Django',
  ]);
  const [formData, setFormData] = useState({ name: '', courseNumber: '' });

  const handleInputChange = (event) => {
    const { name, value } = event.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = (event) => {
    event.preventDefault();

    // Konwersja courseNumber na liczbę
    const courseIndex = parseInt(formData.courseNumber, 10) - 1;

    if (courseIndex >= 0 && courseIndex < courses.length) {
      console.log(`Imię i nazwisko: ${formData.name}`);
      console.log(`Wybrany kurs: ${courses[courseIndex]}`);
      alert(`Zapisano na kurs: ${courses[courseIndex]}`);
    } else {
      console.error('Nieprawidłowy numer kursu');
      alert('Nieprawidłowy numer kursu');
    }
  };

  return (
    <div className="mt-4">
      <h2>Liczba kursów: {courses.length}</h2>
      <ol>
        {courses.map((course, index) => (
          <li key={index}>{course}</li>
        ))}
      </ol>
      <form onSubmit={handleSubmit} className="mt-4">
        <div className="form-group">
          <label htmlFor="name">Imię i nazwisko:</label>
          <input
            type="text"
            className="form-control"
            id="name"
            name="name"
            value={formData.name}
            onChange={handleInputChange}
          />
        </div>
        <div className="form-group mt-3">
          <label htmlFor="courseNumber">Numer kursu:</label>
          <input
            type="number"
            className="form-control"
            id="courseNumber"
            name="courseNumber"
            value={formData.courseNumber}
            onChange={handleInputChange}
          />
        </div>
        <button type="submit" className="btn btn-primary mt-3">
          Zapisz do kursu
        </button>
      </form>
    </div>
  );
}

export default Courses;
