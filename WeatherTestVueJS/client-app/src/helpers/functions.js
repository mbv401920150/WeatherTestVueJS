export function sortByName(a, b, prop) {
  var nameA = a[prop].toUpperCase();
  var nameB = b[prop].toUpperCase();

  if (nameA < nameB) return -1;
  if (nameA > nameB) return 1;

  // names must be equal
  return 0;
}

export const getToday = () => new Date().toISOString().split("T")[0];
